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

			//setup the grid
			gridAddressBook.Columns.Add( "Title", "Title" );
			gridAddressBook.Columns.Add( "Host", "Host" );
			gridAddressBook.Columns.Add( "Comment", "Comment" );

			gridAddressBook.Columns["Title"].Width = 100;
			gridAddressBook.Columns["Host"].Width = 100;
			gridAddressBook.Columns["Comment"].Width = 100;

			// refresh grid
			currentEntry = null;
			RefreshGrid();
		}

		#endregion

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

			gridAddressBookSkipEvents = false;
        }


		private void gridAddressBook_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex == -1 || e.RowIndex == -1 )
				return;

			DataGridViewRow row = gridAddressBook.Rows[e.RowIndex];
			AddressBookEntry abEntry = map[row];

			if ( abEntry != currentEntry )
				throw new Exception( "Oops, they need to match...." );

			formMain.SetConnection( currentEntry );
			this.Close();
		}


		private void gridAddressBook_SelectionChanged( object sender, EventArgs e )
		{
			if ( gridAddressBookSkipEvents )
				return;

			// if nothing or >1 is selected, we don't like it

			if ( gridAddressBook.SelectedRows.Count != 1 )
			{
				currentEntry = null;
				//EditPopulateFields( null );
				return;
			}

			DataGridViewRow row = gridAddressBook.SelectedRows[0];

			currentEntry = map[row];

			//EditPopulateFields( currentEntry );
		}


		private void linkConnect_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( currentEntry == null )
			{
				MessageBox.Show( this, "Nothing is selected" );
				return;
			}

			formMain.SetConnection( currentEntry );
			this.Close();
		}


		private void FormAddressBook_FormClosed( object sender, FormClosedEventArgs e )
		{
			formMain.formAddressBook = null;
		}


		private void linkBookSave_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
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

		private void linkBookLoad_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
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

			// refresh grid
			currentEntry = null;
			RefreshGrid();
		}

		private void linkLoadSample_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			addressBook.AppendSampleData();
			RefreshGrid();
		}

		private void linkClear_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			DialogResult result = MessageBox.Show( "Clear AddressBook with " + addressBook.Book.Count + " entries?", "Confirm", MessageBoxButtons.OKCancel );
			if ( result == DialogResult.Cancel )
				return;

			addressBook.Clear();
			currentEntry = null;
			RefreshGrid();
		}


		private void linkNew_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
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

			RefreshGrid();
		}

		private void linkEdit_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( currentEntry == null )
				return;

			// we make a copy of the current entry, and send that for edit.
			// if user approves of his/her edit, then we replace current with data from edited copy.
			AddressBookEntry copyOfCurrent = new AddressBookEntry( currentEntry );
			FormAddressBookEntry formABE = new FormAddressBookEntry( copyOfCurrent, AddressBookEntryAction.Edit );

			DialogResult result = formABE.ShowDialog( this );

			if ( result == DialogResult.Cancel )
			{
				MessageBox.Show( this, "Edit cancelled" );
				return;
			}

			// add update current entry with edited data
			currentEntry.UpdateFrom( copyOfCurrent );

			RefreshGrid();
		}

		private void linkDelete_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( currentEntry == null )
				return;

			DialogResult result = MessageBox.Show(
				this,
				"Are you sure you want to delete the current entry?",
				"Please confirm",
				MessageBoxButtons.OKCancel
				);

			if ( result == DialogResult.Cancel )
				return;

			addressBook.DeleteEntry( currentEntry );

			RefreshGrid();
		}


	}//FormAddressBook

}//ns

