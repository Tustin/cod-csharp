using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
	internal static class Utilities
	{
		internal const string BO3_URL   = "https://my.callofduty.com/api/papi-client/crm/cod/v2/title/bo3/";
		internal const string IW_URL    = "https://my.callofduty.com/api/papi-client/crm/cod/v2/title/iw/";
		internal const string WWII_URL  = "https://my.callofduty.com/api/papi-client/crm/cod/v2/title/wwii/";

		internal static string ResolvePlatform(Platform platform)
		{
			switch (platform)
			{
				case Platform.PC:
				return "steam";
				case Platform.PSN:
				return "psn";
				case Platform.XB1:
				return "xbl";
				default:
				return null;
			}
		}
	}
}
