using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.Lib;


namespace Kpo4381.nmv.Lib
{
    public class MaterialTestFactory : IMaterialFactory
    {

        public IMaterialListLoader CreateMaterialListLoader()
        {
           return new MaterialListTestLoader();

        }

        public IMaterialListSaver CreateMaterialListSaver()
        {
            return new MaterialListTestSaver();
        }
    }
}
