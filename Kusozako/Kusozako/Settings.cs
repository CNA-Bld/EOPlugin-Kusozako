using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusozako
{
	class Settings
	{
		public bool Enabled { get; set; } = true;
		public string Proxy { get; set; } = "";
		public string ProberUri { get; set; } = "/kcs2/version.json";
		public int MaxDepth { get; set; } = 2434;
	}
}
