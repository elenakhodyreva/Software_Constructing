using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.nmv.Lib.source.my_classes
{
    public class Material
    {
        public string name { get; set; }
        public char materialType { get; set; }
        public int humidity { get; set; }
        public double coefficient { get; set; }



        public Material()
        {
            //хотя они так и так по умолчанию должны инициализироваться без явного указания
            name = "";
            materialType = ' ';
            humidity = 0;
            coefficient = 0;
        }
    }
}
