using System;
using System.Collections.Generic;

using Anton.FtpClientGui.Domain;


namespace Anton.FtpClientGui.Util
{

	public static class DataWarehouse
	{

		#region Data

		public static AddressBook addressBook;

		public static Dictionary<AddressBookEntry, Site> sites;


		private static string DEFAULT_ADDRESS_BOOK = @"_DataSets/AddressBooks/sample01.xml";

		#endregion


		static DataWarehouse()
		{
			sites = new Dictionary<AddressBookEntry, Site>();

			// load default address book
			//TODO: if error loading default address book, need a graceful resolution
			addressBook = AddressBookSerializer.LoadFromFile( DEFAULT_ADDRESS_BOOK );
		}


		public static Site GetSite( AddressBookEntry abEntry )
		{
			if ( ! sites.ContainsKey(abEntry) )
			{
				Site site = new Site( abEntry );
				sites.Add( abEntry, site );
			}

			return sites[abEntry];
		}

	}//class DataWarehouse

}//ns

