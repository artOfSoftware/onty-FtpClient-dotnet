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
			textHostname.Text = entry.host;
			textUsername.Text = entry.userName;
			textPassword.Text = entry.userPass;
			textIniDir.Text = entry.iniDir;
			textComment.Text = entry.comment;
		}


		private void UnpopulateFields( AddressBookEntry entry )
		{
			entry.title = textTitle.Text;
			entry.host = textHostname.Text;
			entry.userName = textUsername.Text;
			entry.userPass = textPassword.Text;
			entry.iniDir = textIniDir.Text;
			entry.comment = textComment.Text;
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

