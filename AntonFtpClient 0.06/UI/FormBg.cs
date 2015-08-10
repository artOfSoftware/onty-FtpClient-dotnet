using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Windows.Forms;

using ArxOne.Ftp;

using Anton.FtpClientGui.Domain;
using Anton.FtpClientGui.Util;


namespace Anton.FtpClientGui.UI
{

	public partial class FormBg : Form
	{

		#region Data

		private FormFtpClient formMain;

		private Site site;
		private SiteEntry dirStart;

		//private ConcurrentQueue<AccItem> outputQueue;

		private BgThread thread;

		private Dictionary<string, DataGridViewRow> map;

		#endregion


		public FormBg( FormFtpClient formMain, Site site, SiteEntry dirStart )
		{
			InitializeComponent();

			this.formMain = formMain;

			this.site = site;
			this.dirStart = dirStart;

			//this.ftp = new FtpClient( site.uri, site.cred );

			//this.outputQueue = new ConcurrentQueue<AccItem>();

			// prep grid
			gridDirs.Columns.Add( "Path", "Path" );
			gridDirs.Columns.Add( "Files", "#Files" );
			gridDirs.Columns.Add( "Dirs", "#Dirs" );
			gridDirs.Columns.Add( "Links", "#Links" );
			gridDirs.Columns.Add( "Size", "Size(b)" );

			gridDirs.Columns["Path"].Width = 200;

			gridDirs.Columns["Files"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridDirs.Columns["Dirs"] .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridDirs.Columns["Links"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridDirs.Columns["Size"] .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


			// give user instructions
			HandleMessageDebug( "Please click Start to begin recursive FTP space usage evaluation.");
		}


		#region form clos*

		private void FormBg_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( thread.running )
			{
				DialogResult result = MessageBox.Show( this, "This will cancel the recursive operation. Allow?", "Cancel?", MessageBoxButtons.YesNo );
				if ( result == DialogResult.No )
				{
					e.Cancel = true;
					return;
				}

				thread.cancelRequested = true;
				//System.Threading.Thread.Sleep( 1000 );
				thread.Join();
			}

		}

		private void FormBg_FormClosed( object sender, FormClosedEventArgs e )
		{
			formMain.formBg = null;
		}

		#endregion


		#region commands

		private void linkStart_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			// if already running, do nothing
			if ( this.thread != null && this.thread.running )
				return;

			if ( this.thread == null )
				this.thread = new BgThread( 71, site, dirStart );

			// subscribe
			thread.EventImportant += HandleMessageImportant;
			thread.EventDebug += HandleMessageDebug;

			map = new Dictionary<string, DataGridViewRow>();
			gridDirs.Rows.Clear();

			HandleMessageDebug( "Starting in dir '" + this.dirStart + "'" );
			thread.Start();

			UpdateUi();
		}

		private void linkStop_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			// if already running, do nothing
			if ( ! thread.running )
				return;

			thread.cancelRequested = true;
			thread.Join();

			// delete the thread. we will make a new one next time we run.
			thread = null;

			UpdateUi();
		}

		#endregion


		private void UpdateUi()
		{
			if ( thread != null && thread.running )
			{
				linkStart.Enabled = false;
				linkStart.Enabled = true;
			}
			else
			{
				linkStart.Enabled = true;
				linkStart.Enabled = false;
			}
		}


		private delegate void MethodCaller2( AccItem data );
		private delegate void MethodCaller3( string message );

		private void HandleMessageDebug( string debugMessage )
		{
			if ( textOut.IsDisposed )
				return;

			if ( textOut.InvokeRequired )
			{
				MethodCaller3 d = new MethodCaller3( textOut.AppendText );
				textOut.Invoke( d, new object[] { debugMessage + Environment.NewLine } );
			}
			else
				textOut.AppendText( debugMessage + Environment.NewLine );
		}


		private void HandleMessageImportant( AccItem data )
		{
			if ( gridDirs.InvokeRequired )
			{
				MethodCaller2 d = new MethodCaller2( AddRow );
				gridDirs.Invoke( d, new object[] { data } );
			}
			else
				AddRow( data );
		}



		private void AddRow( AccItem data )
		{
			//// do i need this???
			//if ( gridDirs.IsDisposed )
			//	return;

			if ( ! map.ContainsKey(data.path) )
			{
				// not in map, need to make new row
				int id = gridDirs.Rows.Add();
				DataGridViewRow row = gridDirs.Rows[id];

				row.Cells["Path"] .Value = data.path;
				row.Cells["Files"].Value = data.countFiles.ToString(     "###,###,##0" );
				row.Cells["Dirs"] .Value = data.countDirs .ToString(     "###,###,##0" );
				row.Cells["Links"].Value = data.countLinks.ToString(     "###,###,##0" );
				row.Cells["Size"] .Value = data.size      .ToString( "###,###,###,##0" );

				// add to map
				map.Add( data.path, row );
			}
			else
			{
				// already in map, need to update existing row

				DataGridViewRow row = map[data.path];

				row.Cells["Path"]. Value = data.path + " (updated)";
				row.Cells["Files"].Value = data.countFiles.ToString(     "###,###,##0" );
				row.Cells["Dirs"] .Value = data.countDirs .ToString(     "###,###,##0" );
				row.Cells["Links"].Value = data.countLinks.ToString(     "###,###,##0" );
				row.Cells["Size"] .Value = data.size      .ToString( "###,###,###,##0" );
			}

		}


	}//class FormBg


}//ns

