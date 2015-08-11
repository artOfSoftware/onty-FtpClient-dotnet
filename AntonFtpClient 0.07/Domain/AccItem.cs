using System;
using System.Collections.Generic;
using System.Text;


namespace Anton.FtpClientGui.Domain
{

	public struct AccItem
	{
		public string path;
		public long size;
		public int countFiles;
		public int countDirs;
		public int countLinks;

		public void Accumulate( AccItem item )
		{
			this.size += item.size;
			this.countFiles += item.countFiles;
			this.countDirs += item.countDirs;
			this.countLinks += item.countLinks;
		}

	}


}//ns
