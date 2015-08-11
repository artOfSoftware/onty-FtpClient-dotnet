using System.Xml.Serialization;
using System.IO;

using Anton.FtpClientGui.Domain;


namespace Anton.FtpClientGui.Util
{

	public static class AddressBookSerializer
	{

		public static void SaveToFile( AddressBook addressBook, string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( Domain.AddressBook ) );

			TextWriter tw = new StreamWriter( fileName );

			XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
			xns.Add( string.Empty, string.Empty );

			serializer.Serialize( tw, addressBook, xns );

			tw.Close();
		}


		public static AddressBook LoadFromFile( string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( Domain.AddressBook ) );

			TextReader tr = new StreamReader( fileName );

			XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
			xns.Add( string.Empty, string.Empty );

			AddressBook addressBook = (AddressBook)serializer.Deserialize( tr );

			tr.Close();

			return addressBook;
		}


	}

}//ns

