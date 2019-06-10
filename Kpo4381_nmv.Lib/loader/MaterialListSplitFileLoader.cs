using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.nmv.Lib.source.my_classes;
using System.IO;

namespace Kpo4381.nmv.Lib
{
    

    public enum LoadStatus
    {
        None= 0,
        Success =1,
        FileNameIsEmpty= -1,
        FileNotExist=-2,
        GeneralError=-100
    }

    public class MaterialListSplitFileLoader : IMaterialListLoader
    {
        private readonly string dataFileName="";
        private List<Material> materials;
        private LoadStatus loadStatus= LoadStatus.None;

        

        public List<Material> getMaterials { get { return materials; } }
        public LoadStatus getLoadStatus { get { return loadStatus; } }

        public MaterialListSplitFileLoader(string fileName)
        {
            dataFileName = fileName;
            materials = new List<Material>();
            
        }



        public void Execute()
        {
            materials = new List<Material>();

            if(dataFileName== null || dataFileName.Equals(""))
            {
                throw new Exception("имя файла не указано");
            }

            if (!File.Exists(dataFileName))
            {
                throw new Exception("Файл не существует");
            }

            

            //прочитать файл построчно
            StreamReader reader = null;
            using (reader= new StreamReader(dataFileName))
            {
                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    string[] arr = str.Split('|');

                    string matname = arr[0];
                    char matType = Char.Parse(arr[1]);
                    int mathumidity = Int32.Parse(arr[2]);
                    double matcoefficient = Double.Parse(arr[3]);

                    //Material material = new Material()
                    //{
                    //    //name = arr[0],
                    //    //materialType = Char.Parse(arr[1]),
                    //    //humidity = Int32.Parse(arr[2]),
                    //    //coefficient = Double.Parse(arr[3])
                    //};



                    materials.Add(new Material()
                    {
                        name = arr[0],
                        materialType= Char.Parse(arr[1]),
                        humidity= Int32.Parse(arr[2]),
                        coefficient= Double.Parse(arr[3]) }
                    );
                }
            }

            loadStatus = LoadStatus.Success;
        }
    }
}
