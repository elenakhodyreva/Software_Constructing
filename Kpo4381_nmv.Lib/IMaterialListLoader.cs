using System.Collections.Generic;
using Kpo4381.nmv.Lib.source.my_classes;


namespace Kpo4381.nmv.Lib
{
    public interface IMaterialListLoader
    {
        LoadStatus getLoadStatus { get; }
        List<Material> getMaterials { get; }

        void Execute();
    }
}