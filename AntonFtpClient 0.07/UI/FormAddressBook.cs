using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Anton.FtpClientGui.Domain;
using Anton.FtpClientGui.Util;


namespace Anton.FtpClientGui.UI
{

	public partial class FormAddressBook : Form
	{

		#region data

		private FormFtpClient formMain;

		private AddressBookEntry currentEntry;
		private AddressBook addressBook;
		private Dictionary<DataGridViewRow, AddressBookEntry> map;

		private bool gridAddressBookSkipEvents = false;


		#endregion

		#region ctor

		public FormAddressBook( FormFtpClient formMain )
		{
			InitializeComponent();

			this.formMain = formMain;

			// get address book
			addressBook = DataWarehouse.addressBook;

			// init the grid columns
			InitGrid();

			// refresh grid
			RefreshGrid();
		}

		#endregion

		#region Actions

		private void InitGrid()
		{
			gridAddressBook.Columns.Clear();

			//setup the grid
			gridAddressBook.Columns.Add( "Title", "Title" );
			gridAddressBook.Columns.Add( "Host", "Host" );
			gridAddressBook.Columns.Add( "Comment", "Comment" );

			gridAddressBook.Columns["Title"].Width = 100;
			gridAddressBook.Columns["Host"].Width = 100;
			gridAddressBook.Columns["Comment"].Width = 100;
		}

		//TODO: Right now after refresh, selection is lost. Perhaps we should re-select after refresh what was selected before refresh. Problems: What if multiple items were selected? What if item(s) were deleted? What if item was edited?
		private void RefreshGrid()
		{
			gridAddressBookSkipEvents = true;

			map = new Dictionary<DataGridViewRow, AddressBookEntry>();
			gridAddressBook.Rows.Clear();

			foreach ( AddressBookEntry entry in addressBook.Book )
			{
				int id = gridAddressBook.Rows.Add();
				DataGridViewRow row = gridAddressBook.Rows[id];
				row.Cells["Title"].Value   = entry.title;
				row.Cells["Host"].Value    = entry.host;
				row.Cells["Comment"].Value = entry.comment;

				map.Add( row, entry );
			}

			gridAddressBook.ClearSelection();
			currentEntry = null;

			gridAddressBookSkipEvents = false;
        }




		private void ABE_Connect( AddressBookEntry abEntry )
		{
			try
			{
				formMain.SetConnection( abEntry );
				this.Close();
			}
			catch ( Exception ex )
			{
				MessageBox.Show(
					this,
					"There was an error:" + Environment.NewLine + Environment.NewLine + ex.Message, "Error connecting to FTP site"
				);
			}
		}

		private void ABE_New()
		{
			AddressBookEntry newAbEntry = new AddressBookEntry();
			FormAddressBookEntry formABE = new FormAddressBookEntry( newAbEntry, AddressBookEntryAction.Create );

			DialogResult result = formABE.ShowDialog( this );

			if ( result == DialogResult.Cancel )
			{
				MessageBox.Show( this, "Create cancelled" );
				return;
			}

			// add new entry to address book
			addressBook.AddEntry( newAbEntry );
		}

		private void ABE_Edit( AddressBookEntry abEntry )
		{
			// we make a copy of the current entry, and send that for edit.
			// if user approves of his/her edit, then we replace current with data from edited copy.
			AddressBookEntry copyOfCurrent = new AddressBookEntry( abEntry );
			FormAddressBookEntry formABE = new FormAddressBookEntry( copyOfCurrent, AddressBookEntryAction.Edit );

			DialogResult result = formABE.ShowDialog( this );

			if ( result == DialogResult.Cancel )
			{
				MessageBox.Show( this, "Edit cancelled" );
				return;
			}

			// add update current entry with edited data
			abEntry.UpdateFrom( copyOfCurrent );
		}

		private void ABE_Delete( List<AddressBookEntry> list )
		{
			DialogResult result = MessageBox.Show(
				this,
				"Are you sure you want to delete " + list.Count + " entries?",
				"Please confirm",
				MessageBoxButtons.OKCancel
				);

			if ( result == DialogResult.Cancel )
				return;

			foreach ( AddressBookEntry abe in list )
				addressBook.DeleteEntry( abe );
		}

		private void AB_LoadSample()
		{
			addressBook.AppendSampleData();
		}

		private void AB_Clear()
		{
			DialogResult result = MessageBox.Show( "Clear AddressBook with " + addressBook.Book.Count + " entries?", "Confirm", MessageBoxButtons.OKCancel );
			if ( result == DialogResult.Cancel )
				return;

			addressBook.Clear();
		}

		private void AB_SaveToFile()
		{
			// get file name
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "XML Files (*.xml)|*.xml";
			dialog.FilterIndex = 0;
			dialog.InitialDirectory = Application.StartupPath;

			DialogResult result = dialog.ShowDialog( this );

			if ( result == DialogResult.Cancel )
				return;

			string fileName = dialog.FileName;

			// save file
			AddressBookSerializer.SaveToFile( addressBook, fileName );
		}

		private void AB_LoadFromFile()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "XML Files (*.xml)|*.xml";
			dialog.FilterIndex = 0;
			dialog.InitialDirectory = Application.StartupPath;

			DialogResult result = dialog.ShowDialog( this );

			if ( result == DialogResult.Cancel )
				return;

			string fileName = dialog.FileName;

			// read file
			addressBook = AddressBookSerializer.LoadFromFile( fileName );
		}


		private List<AddressBookEntry> SelectedEntries()
		{
			List<AddressBookEntry> list = new List<AddressBookEntry>();
			foreach ( DataGridViewRow row in gridAddressBook.SelectedRows )
				list.Add( map[row] );
			return list;
		}

		#endregion Actions


		#region EVENT HANDLERS

		private void gridAddressBook_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex == -1 || e.RowIndex == -1 )
				return;

			ABE_Connect( currentEntry );
		}


		private void gridAddressBook_SelectionChanged( object sender, EventArgs e )
		{
			if ( gridAddressBookSkipEvents )
				return;

			// if nothing or >1 is selected, we don't like it
			if ( gridAddressBook.SelectedRows.Count != 1 )
			{
				currentEntry = null;
				return;
			}

			DataGridViewRow row = gridAddressBook.SelectedRows[0];
			currentEntry = map[row];
		}


		private void linkConnect_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( currentEntry == null )
			{
				MessageBox.Show( this, "Please select exactly 1 address book entry to connect." );
				return;
			}

			ABE_Connect( currentEntry );
		}


		private void FormAddressBook_FormClosed( object sender, FormClosedEventArgs e )
		{
			formMain.formAddressBook = null;
		}


		private void linkBookSave_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			AB_SaveToFile();
		}

		private void linkBookLoad_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			AB_LoadFromFile();

			// refresh grid
			currentEntry = null;
			RefreshGrid();
		}

		private void linkLoadSample_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			AB_LoadSample();
			RefreshGrid();
		}

		private void linkClear_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			AB_Clear();
			RefreshGrid();
		}


		private void linkNew_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			ABE_New();
			RefreshGrid();
		}

		private void linkEdit_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( currentEntry == null )
				return;

			ABE_Edit( currentEntry );
			RefreshGrid();
		}

		private void linkDelete_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			//if ( currentEntry == null )
			//	return;

			ABE_Delete( SelectedEntries() );
			RefreshGrid();
		}
		
		#endregion


		#region context menu for grid

		private void contextMenuStrip1_Opening( object sender, System.ComponentModel.CancelEventArgs e )
		{
			DataGridViewSelectedRowCollection selectedRows = gridAddressBook.SelectedRows;

			// enable connect and edit only if there is exactly one selected entry
			if ( selectedRows.Count == 1 )
			{
				toolStripMenuItem_Connect.Enabled = true;
				toolStripMenuItem_Connect.Text = toolStripMenuItem_Connect.Tag + " " + currentEntry.title;

				toolStripMenuItem_Edit.Enabled = true;
				toolStripMenuItem_Edit.Text = toolStripMenuItem_Edit.Tag + " " + currentEntry.title;
			}
			else
			{
				toolStripMenuItem_Connect.Enabled = false;
				toolStripMenuItem_Connect.Text = toolStripMenuItem_Connect.Tag + "...";

				toolStripMenuItem_Edit.Enabled = false;
				toolStripMenuItem_Edit.Text = toolStripMenuItem_Edit.Tag + "...";
			}

			// enable delete only if there is at least one selected entry
			if ( selectedRows.Count > 0 )
			{
				toolStripMenuItem_Delete.Enabled = true;
				toolStripMenuItem_Delete.Text = toolStripMenuItem_Delete.Tag + " " + selectedRows.Count + " items";
			}
			else
			{
				toolStripMenuItem_Delete.Enabled = false;
				toolStripMenuItem_Delete.Text = toolStripMenuItem_Delete.Tag + "...";
			}


		}

		private void toolStripMenuItem_Connect_Click( object sender, EventArgs e )
		{
			ABE_Connect( currentEntry );
			RefreshGrid();
		}

		private void toolStripMenuItem_Edit_Click( object sender, EventArgs e )
		{
			ABE_Edit( currentEntry );
			RefreshGrid();
		}

		private void toolStripMenuItem_Delete_Click( object sender, EventArgs e )
		{
			ABE_Delete( SelectedEntries() );
			RefreshGrid();
		}

		private void toolStripMenuItem_New_Click( object sender, EventArgs e )
		{
			ABE_New();
			RefreshGrid();
		}


		private void toolStripMenuItem_LoadFromFile_Click( object sender, EventArgs e )
		{
			AB_LoadFromFile();
			RefreshGrid();
		}

		private void toolStripMenuItem_SaveToFile_Click( object sender, EventArgs e )
		{
			AB_SaveToFile();
			RefreshGrid();
		}

		private void toolStripMenuItem_Clear_Click( object sender, EventArgs e )
		{
			AB_Clear();
			currentEntry = null;
			RefreshGrid();
		}

		private void toolStripMenuItem_AppendSampleData_Click( object sender, EventArgs e )
		{
			AB_LoadSample();
			RefreshGrid();
		}

		private void toolStripMenuItem_Refresh_Click( object sender, EventArgs e )
		{
			RefreshGrid();
		}


		#endregion

	}//FormAddressBook

}//ns

