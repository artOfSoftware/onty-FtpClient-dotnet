using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Anton.FtpClientGui.Domain;


namespace Anton.FtpClientGui.UI
{

	public partial class FormAddressBookEntry : Form
	{

		private AddressBookEntry abEntry;


		public FormAddressBookEntry( AddressBookEntry abEntry, AddressBookEntryAction action )
		{
			InitializeComponent();

			this.abEntry = abEntry;

			// set header
			if ( action == AddressBookEntryAction.Create )
				labelHeader.Text = "Creating new entry";
			else if ( action == AddressBookEntryAction.Edit )
				labelHeader.Text = "Editing entry";
			else
				labelHeader.Text = "Unknown operation";

			// populate fields
			PopulateFields( abEntry );
		}


		private void PopulateFields( AddressBookEntry entry )
		{
			if ( entry == null )
				entry = new AddressBookEntry();

			textTitle.Text = entry.title;
			textHost.Text = entry.host;
			textPort.Text = entry.port.ToString();
			textUsername.Text = entry.userName;
			textPassword.Text = entry.userPass;
			textIniDir.Text = entry.iniDir;
			textComment.Text = entry.comment;
		}


		// TODO: Need error checking for info: Make sure host has valid format, user name is not blank.
		private bool UnpopulateFields( AddressBookEntry entry )
		{
			entry.title = textTitle.Text;
			entry.host = textHost.Text;
			entry.userName = textUsername.Text;
			entry.userPass = textPassword.Text;
			entry.iniDir = textIniDir.Text;
			entry.comment = textComment.Text;

			try
			{
				entry.port = Int32.Parse( textPort.Text );
				if ( entry.port < 0 || entry.port > 70000 )
					throw new Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show( this, "Please make sure the port is an integer number between 1 and 70000" );
				return false;
			}

			return true;
		}

		private void linkSave_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			UnpopulateFields( abEntry );

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void linkCancel_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}


	}


	public enum AddressBookEntryAction
	{
		Create,
		Edit
	}


}//ns

