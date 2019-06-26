using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.Utility;
using Kpo4381.nmv.Lib;

namespace Kpo4381.Lib
{
    public static class AppGlobalSettings
    {
        private static string logPath;
        private static string dataFileName;

        //объект фабрики
        private static IMaterialFactory materialFactory;
        public static IMaterialFactory GetMaterialFactory { get { return materialFactory; } }

        //тип фабрики
        private static string factoryType;
        public static string GetFactoryType { get { return factoryType; } }



        public static string getLogPath { get { return logPath; } }
        public static string getDataFileName { get { return dataFileName; } }

        public static void Initialize()
        {
            AppConfigUtility appConfigUtility = new AppConfigUtility();
            logPath = appConfigUtility.AppSettings("logPath");
            dataFileName = appConfigUtility.AppSettings("dataFileName");




            //объявление фабрики в зависимости от типа фабрики
            factoryType = appConfigUtility.AppSettings("factoryType");


                if (factoryType.Equals("split"))
                {
                    materialFactory = new MaterialSplitFileFactory();
                }
                else if (factoryType.Equals("test"))
                {
                    materialFactory = new MaterialTestFactory();
                }
                else
                    throw new Exception("this factory type doesn't exist!!!");

        }
    }
}
