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

		public void AddEntry( string title, string host, int port, string user, string pass, string iniDir, string comment )
		{
			AddressBookEntry entry = new AddressBookEntry( title, host, port, user, pass, iniDir, comment );
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
			AddEntry( "swfwmd", "ftp.swfwmd.state.fl.us", 21, "ftp", "test@here.com", "/", "a real public site" );
			AddEntry( "FreeBSD.org", "ftp.ch.freebsd.org", 21, "ftp", "test@here.com", "/", "a real public site" );
			AddEntry( "IU.edu", "ftp.ussg.iu.edu", 21, "ftp", "test@here.com", "/", "a real public site" );
			AddEntry( "Kernel.org", "ftp.kernel.org", 21, "ftp", "test@here.com", "/", "a real public site" );
			AddEntry( "Mirror.nl", "ftp.mirror.nl", 21, "ftp", "test@here.com", "/", "a real public site" );
			AddEntry( "RedIris", "ftp.rediris.es", 21, "ftp", "test@here.com", "/", "a real public site" );
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

		[XmlElement( "Port" )]
		public int port;

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

		public AddressBookEntry( string title, string host, int port, string user, string pass, string iniDir, string comment )
		{
			this.title    = title;
			this.host     = host;
			this.port     = port;
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

