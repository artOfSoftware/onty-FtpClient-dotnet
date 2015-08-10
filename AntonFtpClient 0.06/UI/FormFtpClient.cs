using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ArxOne.Ftp;

using Anton.FtpClientGui.Domain;
using Anton.FtpClientGui.Util;


namespace Anton.FtpClientGui.UI
{
	
	public partial class FormFtpClient : Form
	{

		#region Data

		private Site site;

		private Dictionary<DataGridViewRow, SiteEntry> map;
		private Dictionary<TreeNode, SiteEntry> mapTree;

		// forms
		public FormBg formBg;
		public FormAddressBook formAddressBook;

		#endregion



		#region ctor

		public FormFtpClient()
		{
			InitializeComponent();

			// title bar
			this.Text = Application.ProductName + " " + Application.ProductVersion;

			// setup grid
			DataGridViewImageColumn ic = new DataGridViewImageColumn( false );
			ic.Name = "Type";
			gridItems.Columns.Add( ic );

			gridItems.Columns.Add( "Name", "Name" );
			gridItems.Columns.Add( "Size", "Size" );
			gridItems.Columns.Add( "Date", "Date" );

			gridItems.Columns["Type"].Width = 34;
			gridItems.Columns["Name"].Width = 200;
			gridItems.Columns["Size"].Width = 100;
			gridItems.Columns["Size"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridItems.Columns["Date"].Width = 120;

			// update
			UpdateUi();
		}

		#endregion


		public void SetConnection( AddressBookEntry abEntry )
		{
			site = DataWarehouse.GetSite( abEntry );
			site.SiteUpdatedEvent += HandleSiteUpdatedEvent;

			mapTree = new Dictionary<TreeNode, SiteEntry>();

			SiteEntry rootEntry;

			labelHostName.Text = site.addressBookEntry.host;

			//try
			//{
				SetAppState( AppState.Busy );
				rootEntry = ChangeDir( null, true );
				SetAppState( AppState.Available );
			//}
			//catch ( Exception ex )
			//{
			//	SetAppState( AppState.Available );
			//	MessageBox.Show( this, ex.Message );
			//	return;
			//}

			TreeBuild();
		}

		private void HandleSiteUpdatedEvent( SiteEntry entry )
		{
			if ( treeDirs.InvokeRequired )
			{
				MethodInvoker4 d = new MethodInvoker4( TreeUpdate );
				treeDirs.Invoke( d, new object[] { entry } );
			}
			else
				TreeUpdate( entry );
		}

		public delegate void MethodInvoker4( SiteEntry siteEntry );

		private SiteEntry ChangeDir( string path, bool initial = false )
		{
			SiteEntry siteEntry;

			if ( initial )
			{
				siteEntry = site.Connect();
				path = site.currentDir.Path.ToString();
			}
			else
				siteEntry = site.GotoDir( path );

			labelCwd.Text = path;


			// clear the grid, and populate
			gridItems.Rows.Clear();
			map = new Dictionary<DataGridViewRow, SiteEntry>();

			foreach ( SiteEntry siteEntry2 in siteEntry.subItems )
			{
				FtpEntry item = siteEntry2.myFtpEntry;

				int id = gridItems.Rows.Add();
				DataGridViewRow row = gridItems.Rows[id];

				row.Cells["Type"].Value = GetIconForType( item.Type );
				row.Cells["Name"].Value = item.Name;
				row.Cells["Size"].Value = String.Format( "{0:#,###,###,###}", (long)item.Size );
				row.Cells["Date"].Value = item.Date;

				map.Add( row, siteEntry2 );
			}

			UpdateUi();

			return siteEntry;
		}


		private Image GetIconForType( FtpEntryType type )
		{
			Image img;

			switch ( type )
			{
				case FtpEntryType.File:
					img = Image.FromFile( @"Icons/16/file-16.png" );
					break;
				case FtpEntryType.Directory:
					img = Image.FromFile( @"Icons/16/folder-16.png" );
					break;
				case FtpEntryType.Link:
					img = Image.FromFile( @"Icons/16/shortcut.png" );
					break;
				default:
					img = new Bitmap( 16,16 );
					break;
			}

			return img;
		}


		private void UpdateUi()
		{
			if ( site == null || site.currentDir.up == null )
				linkCdUp.Enabled = false;
			else
				linkCdUp.Enabled = true;


			if ( this.site == null )
				toolStripMenuItem_AnalyzeSiteUsage.Enabled = false;
			else
				toolStripMenuItem_AnalyzeSiteUsage.Enabled = true;

			// update the tree
			if ( site == null )
				treeDirs.Enabled = false;
			else
				treeDirs.Enabled = true;

		}


		private void TreeBuild()
		{
			treeDirs.Nodes.Clear();

			TreeNode treeRoot = treeDirs.Nodes.Add( "/" );
			//treeRoot.NodeFont = new Font( treeRoot.NodeFont, FontStyle.Bold );
            mapTree.Add( treeRoot, site.root );

			TreeBuildRecursive( treeRoot, site.root );
		}


		private void TreeBuildRecursive( TreeNode treeNode, SiteEntry entry )
		{
			foreach( SiteEntry entry2 in entry.subItems )
			{
				if ( entry2.Type != FtpEntryType.Directory )
					continue;

				TreeNode treeNode2 = treeNode.Nodes.Add( entry2.Name );
				//treeNode2.NodeFont = new Font( treeNode2.NodeFont, FontStyle.Bold );

				if ( ! entry2.IsExplored )
					treeNode2.ForeColor = Color.Gray;

				mapTree.Add( treeNode2, entry2 );

				if ( entry2.subItems != null && entry2.subItems.Count > 0 )
					TreeBuildRecursive( treeNode2, entry2 );
			}
		}

		private void TreeUpdate( SiteEntry entry )
		{
			TreeNode treeNode = null;
			
			foreach ( KeyValuePair<TreeNode,SiteEntry> pair in mapTree )
				if ( pair.Value == entry)
				{
					treeNode = pair.Key;
					break;
				}

			if ( treeNode == null )
			{
				DebugPrintln( "Tree trying to update an entry which was not found" );
				return;
			}

			// clear subitems and repopulate
			//TODO: when we clear out subnodes, corresponding items will still remain in the map. that could be a problem.
			treeNode.Nodes.Clear();
			TreeBuildRecursive( treeNode, entry );

			treeNode.ForeColor = Color.Black;
		}


		private void linkCdUp_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( site == null )
				return;

			ChangeDir( site.currentDir.up.Path.ToString() );
		}


		private void gridItems_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			DataGridViewRow row = gridItems.Rows[e.RowIndex];
			SiteEntry item = map[row];

			if ( item.Type != FtpEntryType.Directory )
				return;

			string newPath = item.Path.ToString();

			SetAppState( AppState.Busy );
			ChangeDir( newPath );
			SetAppState( AppState.Available );
		}


		private void treeDirs_AfterSelect( object sender, TreeViewEventArgs e )
		{
			TreeNode treeNode = e.Node;
			SiteEntry entry = mapTree[treeNode];
			ChangeDir( entry.Path.ToString() );
		}


		#region Menu

		private void toolStripMenuItem_AddressBook_Click( object sender, EventArgs e )
		{
			FormAddressBook formAddressBook = new FormAddressBook( this );
			this.formAddressBook = formAddressBook;
			formAddressBook.Show( this );
		}

		private void toolStripMenuItem_AnalyzeSiteUsage_Click( object sender, EventArgs e )
		{
			if ( this.site == null )
				return;

			// if form is already open, reuse it: bring to front and focus
			if ( this.formBg != null )
			{
				formBg.BringToFront();
				formBg.Focus();
				return;
			}

			formBg = new FormBg( this, site, site.currentDir );
			formBg.Show( this );
		}

		#endregion


		private void DebugPrintln( string s )
		{
			textOut.AppendText( s + Environment.NewLine );
		}


		private void SetAppState( AppState state )
		{
			if ( state == AppState.Busy )
				this.Cursor = Cursors.WaitCursor;
			else
				this.Cursor = Cursors.Default;
		}


		private enum AppState
		{
			Available,
			Busy,
			Other = 6871
		}


	}//class

}//ns

