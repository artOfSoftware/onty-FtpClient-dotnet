using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Anton.FtpClientGui.Domain
{

	public class AddressBook
	{

		#region data

		private List<AddressBookEntry> book;

		#endregion


		#region ctor

		public AddressBook()
		{
			book = new List<AddressBookEntry>();
		}
	
		#endregion

		public void AddEntry( string title, string host, string user, string pass, string iniDir, string comment )
		{
			AddressBookEntry entry = new AddressBookEntry( title, host, user, pass, iniDir, comment );
			book.Add( entry );
		}

		public void AddEntry( AddressBookEntry newEntry )
		{
			book.Add( newEntry );
		}

		public void DeleteEntry( AddressBookEntry entry )
		{
			book.Remove( entry );
		}

		public void Clear()
		{
			book.Clear();
		}

		public void AppendSampleData()
		{
			AddEntry( "sAsp.net", "ftp.annatoom.com", "ontytest", "onty3test4", "/", "a real non-public site" );
			AddEntry( "swfwmd", "ftp.swfwmd.state.fl.us", "ftp", "test@here.com", "/", "a real public site" );
		}


		#region accessors

		[XmlArray( "AddressBookEntries" )]
		public List<AddressBookEntry> Book
		{
			get
			{
				return book;
			}
		}

		#endregion

	}


	//TODO: this also needs a port #
	public class AddressBookEntry
	{
		[XmlElement( "Title" )]
		public string title;

		[XmlElement( "Host" )]
		public string host;

		[XmlElement( "UserName" )]
		public string userName;

		[XmlElement( "UserPass" )]
		public string userPass;

		[XmlElement( "IniDir" )]
		public string iniDir;

		[XmlElement( "Comment" )]
		public string comment;


		// ctor
		public AddressBookEntry()
		{
		}

		public AddressBookEntry( string title, string host, string user, string pass, string iniDir, string comment )
		{
			this.title    = title;
			this.host     = host;
			this.userName = user;
			this.userPass = pass;
			this.iniDir   = iniDir;
			this.comment  = comment;
		}

		public AddressBookEntry( AddressBookEntry getDataFromHere )
		{
			this.UpdateFrom( getDataFromHere );
		}

		public void UpdateFrom( AddressBookEntry getDataFromHere )
		{
			this.title    = getDataFromHere.title;
			this.host     = getDataFromHere.host;
			this.userName = getDataFromHere.userName;
			this.userPass = getDataFromHere.userPass;
			this.iniDir   = getDataFromHere.iniDir;
			this.comment  = getDataFromHere.comment;
		}

	}


}//ns

