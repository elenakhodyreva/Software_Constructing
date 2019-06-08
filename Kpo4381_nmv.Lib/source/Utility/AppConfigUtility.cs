using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4381.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            if (ConfigurationManager.AppSettings[name] != null)
                return ConfigurationManager.AppSettings[name].ToString();
            else
                return "";
        }
    }
}
