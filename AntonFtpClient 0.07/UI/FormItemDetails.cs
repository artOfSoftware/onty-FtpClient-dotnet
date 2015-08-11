using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ArxOne.Ftp;
using Anton.FtpClientGui.Domain;


namespace Anton.FtpClientGui.UI
{

	public partial class FormItemDetails : Form
	{

		public FormItemDetails( SiteEntry entry )
		{
			InitializeComponent();

			InitGrid();

			Populate( entry );
		}


		private void InitGrid()
		{
			gridItem.Columns.Add( "Name", "Name" );
			gridItem.Columns.Add( "Value", "Value" );

			int widthAvailable = gridItem.ClientRectangle.Width - gridItem.RowHeadersWidth;
			gridItem.Columns["Name"].Width = 60;
			gridItem.Columns["Value"].Width = widthAvailable - 60 - 4;
		}

		private void Populate( SiteEntry entry )
		{
			AddRow( "Name", entry.Name );
			AddRow( "Type", entry.Type );
			AddRow( "Path", entry.Path );
			AddRow( "Size", entry.myFtpEntry.Size );
			AddRow( "Target", entry.myFtpEntry.Target );
			AddRow( "Date", entry.myFtpEntry.Date );

			if ( entry.Type != FtpEntryType.File)
				AddRow( "IsExplored", entry.IsExplored );
		}

		private void AddRow( string name, object value )
		{
			int id = gridItem.Rows.Add();
			DataGridViewRow row = gridItem.Rows[id];
			row.Cells["Name"].Value = name;

			string v;
			if ( value == null )
				v = "(null)";
			else
				v = value.ToString();

			row.Cells["Value"].Value = v;
		}

	}

}//ns
