using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anton.FtpClientGui.Util
{

	public class BgUiThread
	{

		private Thread thread;
		private DataGridView grid;


		public BgUiThread( DataGridView grid )
		{
			this.grid = grid;
		}


		private void Run()
		{


		}

	}

}//ns
