using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using ArxOne.Ftp;

using Anton.FtpClientGui.Domain;


namespace Anton.FtpClientGui.Util
{

	public class BgThread
	{

		private Thread thread;
		//private int id;

		private static ConcurrentQueue<FtpEntry> queue;

		public bool running;
		public bool cancelRequested;

		private FtpClient ftp;
		private SiteEntry startEntry;
		private Site site;


		static BgThread()
		{
			queue = new ConcurrentQueue<FtpEntry>();
		}


		public BgThread( int id, Site site, SiteEntry startEntry )
		{
			this.site = site;
			this.startEntry = startEntry;

			this.ftp = new FtpClient( site.uri, site.cred );

			this.thread = new Thread( Run );
			this.thread.Name = "T" + id;

			this.running = false;
			this.cancelRequested = false;
		}

		public void Start( object parameter = null )
		{
			if ( parameter == null )
				thread.Start();
			else
				thread.Start( parameter );
		}

		public void Join()
		{
			thread.Join();
		}

		public Thread Thread
		{
			get
			{
				return thread;
			}
		}

		private void Run()
		{
			SendMessageDebug( "Thread " + thread.Name + " is starting..." );
			running = true;

			// do work:
			// get item from the queue
			// retrieve it from server
			// each folder subitem put on the queue


			DateTime timeStart = DateTime.Now;

			AccItem data = Recurse( startEntry );

			DateTime timeEnd = DateTime.Now;
			TimeSpan timeDiffS = timeEnd - timeStart;


			// report

			StringBuilder sb = new StringBuilder();

			if ( cancelRequested )
				sb.AppendLine( "Cancelled per user request..." );

			sb.AppendFormat(
				"Found {0:###,###,##0} files, {1:###,###,##0} dirs, {2:###,###,##0} links, total size {3:###,###,###,###,##0} bytes",
				data.countFiles, data.countDirs, data.countLinks, data.size
				);
			sb.AppendLine();
			sb.AppendFormat( "Operation took {0:dd\\.hh\\:mm\\:ss}", timeDiffS );
			sb.AppendLine();
			sb.AppendLine( "Done." );

			SendMessageDebug( sb.ToString() );

			running = false;
			SendMessageDebug( "Thread " + thread.Name + " is complete." );
		}


		private AccItem Recurse( SiteEntry path )
		{
			AccItem data = new AccItem();
			data.path = path.Path.ToString();

			//IEnumerable<FtpEntry> items;
			List<SiteEntry> items;

			// if user cancelled, do nothing
			if ( cancelRequested )
				return data;

			string message = "Recurse to " + path.Path;
			SendMessageDebug( message );

			// send item to grid (will be updated later)
			try
			{
				SendMessageImportant( data );
				//outputQueue.Enqueue( data );
			}
			catch ( Exception ex )
			{
				SendMessageDebug( "ERROR1: " + ex.Message );
			}

			// get subitems
			try
			{
				//items = ftp.ListEntries( path );

				if ( ! path.IsExplored )
					site.GetDir( path.Path.ToString() );

				items = path.subItems;
			}
			catch ( Exception ex )
			{
				SendMessageDebug( "ERROR2: " + ex.Message );
				return data;
			}

			// process subitems
			foreach ( SiteEntry item in items )      //FtpEntry item in items
			{
				if ( cancelRequested )
					return data;

				if ( item.Type == FtpEntryType.File )
				{
					data.countFiles++;
					data.size += (long)item.myFtpEntry.Size;
				}
				else if ( item.Type == FtpEntryType.Link )
				{
					data.countLinks++;
					data.size += (long)item.myFtpEntry.Size;
				}
				else if ( item.Type == FtpEntryType.Directory )
				{
					data.countDirs++;

					AccItem data2 = Recurse( item );

					data.Accumulate( data2 );
				}

			}

			// send update for this item
			try
			{
				SendMessageImportant( data );
				//outputQueue.Enqueue( data );
			}
			catch ( Exception ex )
			{
				SendMessageDebug( "ERROR3: " + ex.Message );
			}

			return data;

		}//Recurse()





		#region sending messages

		private void SendMessageImportant( AccItem data )
		{
			if ( EventImportant != null )
				EventImportant.Invoke( data );

		}

		private void SendMessageDebug( string message )
		{
			if ( EventDebug != null )
				EventDebug.Invoke( message );

		}

		public delegate void MessageImportant( AccItem data );
		public delegate void MessageDebug    ( string message );

		public event MessageImportant EventImportant;
		public event MessageDebug     EventDebug;

		#endregion

	}

}//ns
