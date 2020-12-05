using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firewall_Editor
{
    class Constants
    {
        public static string Direction = "Inbound";
        public static string Mode = "Block";
        public static bool DualMode = false;
        public static string prefix = DateTime.Now.ToString("d/m/yyyy") + "_";
        public static int maxCount = 0;
        public static int currentCount = 0;
    }
}
