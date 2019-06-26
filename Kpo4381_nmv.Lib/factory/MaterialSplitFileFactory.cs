using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.Lib;

namespace Kpo4381.nmv.Lib
{
    internal class MaterialSplitFileFactory : IMaterialFactory
    {
        public IMaterialListLoader CreateMaterialListLoader()
        {
            return new MaterialListSplitFileLoader(AppGlobalSettings.getDataFileName);

        }

        public IMaterialListSaver CreateMaterialListSaver()
        {
            return new MaterialListSplitFileSaver();
        }
    }
}
