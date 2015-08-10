using System;
using System.Collections.Generic;
using System.Net;

using ArxOne.Ftp;


namespace Anton.FtpClientGui.Domain
{

	public class Site
	{

		#region Data

		public AddressBookEntry addressBookEntry;
		public SiteEntry root;
		public SiteEntry currentDir;
		private Dictionary<string,SiteEntry> map;

		private FtpClient ftp;
		public Uri uri;
		public NetworkCredential cred;

		#endregion


		#region Ctor

		public Site( AddressBookEntry abEntry )
		{
			this.addressBookEntry = abEntry;

			UriBuilder uriBuilder = new UriBuilder( "ftp", addressBookEntry.host );
			this.uri = uriBuilder.Uri;
			this.cred = new NetworkCredential( addressBookEntry.userName, addressBookEntry.userPass );

			this.map = new Dictionary<string, SiteEntry>();

			this.ftp = new FtpClient( uri, cred );
		}

		#endregion


		#region Events

		public delegate void SiteUpdatedEventHandler( SiteEntry entry );
		public event SiteUpdatedEventHandler SiteUpdatedEvent;

		#endregion


		public SiteEntry Connect()
		{
			// make root entry
			if ( root == null )
			{
				root = new SiteEntry( null, null );
				map.Add( "/", root );
			}
			else
			{
				// TODO: doing this check just in case something is out of sync...
				if ( !map.ContainsKey( "/" ) )
					throw new Exception( "Expecting a / entry in the map, since root is already cached from before" );
			}

			// get subitems of root
			SiteEntry rootEntry = GotoDir( addressBookEntry.iniDir );

			return rootEntry;
		}

		//TODO: add bool param forceRefresh
		public SiteEntry GotoDir( string dir )
		{
			SiteEntry entry = GetDir( dir );

			currentDir = entry;
			return entry;
		}

		public SiteEntry GetDir( string dir )
		{
			SiteEntry entry = map[dir];

			if ( !entry.IsExplored )
			{
				// get it from server
				IEnumerable<FtpEntry> subItems = ftp.ListEntries( dir );
				entry.LearnSubitems( subItems, map );

				if ( SiteUpdatedEvent != null )
					SiteUpdatedEvent.Invoke( entry );
			}

			return entry;
		}


	}//class Site


	public class SiteEntry
	{
		public FtpEntry myFtpEntry;
		public List<SiteEntry> subItems;
		public SiteEntry up;

		public SiteEntry( FtpEntry ftpEntry, SiteEntry up )
		{
			this.myFtpEntry = ftpEntry;
			this.up         = up;
			this.subItems   = null;
		}

		
		public void LearnSubitems( IEnumerable<FtpEntry> subItems, Dictionary<string,SiteEntry> map )
		{
			// TODO: when refreshing a directory, we may need to update this rather than build anew
			this.subItems = new List<SiteEntry>();

			foreach ( FtpEntry item in subItems )
			{
				SiteEntry entryNew = new SiteEntry( item, this );
				this.subItems.Add( entryNew );
				map.Add( item.Path.ToString(), entryNew );
			}

		}


		public bool IsExplored
		{
			get
			{
				return (subItems != null);
			}
		}


		public string Name
		{
			get
			{
				return myFtpEntry.Name;
			}
		}

		public FtpPath Path
		{
			get
			{
				if ( up == null )
					return new FtpPath( "/" );	//TODO: this logic may be flawed. we may need to have a special isRoot field.
				else
					return myFtpEntry.Path;
			}
		}

		public FtpEntryType Type
		{
			get
			{
				return myFtpEntry.Type;
			}
		}


	}//class SiteEntry


}//ns

