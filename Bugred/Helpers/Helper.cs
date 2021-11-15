using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugred
{
    public class Helper
    {
        public static string RandomStringGeneration()
        {
            return DateTime.Now.ToString("ddMMyyyyhhmm");
        }
    }
}
