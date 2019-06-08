using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.Utility;

namespace Kpo4381.Lib
{
    public static class AppGlobalSettings
    {
        private static string logPath;
        private static string dataFileName;

        public static string getLogPath { get { return logPath; } }
        public static string getDataFileName { get { return dataFileName; } }

        public static void Initialize()
        {
            AppConfigUtility appConfigUtility = new AppConfigUtility();
            logPath = appConfigUtility.AppSettings("logPath");
            dataFileName = appConfigUtility.AppSettings("dataFileName");
        }
    }
}
