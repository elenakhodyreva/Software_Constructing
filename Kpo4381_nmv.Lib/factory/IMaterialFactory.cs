using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.nmv.Lib
{
    public enum LoaderType { SPLIT, TEST }

    public interface IMaterialFactory
    {
        IMaterialListLoader CreateMaterialListLoader();
        IMaterialListSaver CreateMaterialListSaver();
    }
}
