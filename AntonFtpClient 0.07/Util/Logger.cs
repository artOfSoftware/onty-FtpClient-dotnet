using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Diagnostics.PerformanceData;


namespace Anton.FtpClientGui.Util
{
	public static class Logger
	{

		public static void Message( string message )
		{
			//Trace.W

			Debug.Print( message );
		}

	}

}
