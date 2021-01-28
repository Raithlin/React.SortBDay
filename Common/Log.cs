using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace React.SortBDay.Common
{
	public class Log
	{
		public Serilog.Core.Logger LogInstance { get; set; }
		public Log()
		{
			LogInstance = new LoggerConfiguration().WriteTo.File("Log.txt", rollingInterval: RollingInterval.Day).CreateLogger();
		}
	}
}