using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo4381.nmv.Lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            
            File.AppendAllText("error.log", DateTime.Now + message);
        }

        public static void ErrorLog(Exception e)
        {
            File.AppendAllText("error.log", e.Message);
        }
    }
}
