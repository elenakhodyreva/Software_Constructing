using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Kpo4381.nmv.Lib.source.my_classes;

namespace Kpo4381.nmv.Lib
{
    public delegate void OnLoadFileDelegate(string curentRow);

    public class MaterialNewLoader_laba4 :IMaterialListLoader
    {
        private readonly string dataFileName = "";
        private List<Material> materials;
        private LoadStatus loadStatus = LoadStatus.None;

        //делегат
        private OnLoadFileDelegate onAfterRowWasRead;

        public List<Material> getMaterials { get { return materials; } }
        public LoadStatus getLoadStatus { get { return loadStatus; } }

        public string getFileName { get { return dataFileName; } }

        public MaterialNewLoader_laba4(string fileName)
        {
            dataFileName = fileName;
            materials = new List<Material>();
            onAfterRowWasRead = null;
        }

        //методы доступа к делегату сеттер
        public void SetAfterRowWasRead(OnLoadFileDelegate onAfterRowWasRead)
        {
            this.onAfterRowWasRead = onAfterRowWasRead;
        }

        //геттер
        public OnLoadFileDelegate AfterRowWasRead
        {
            get
            {
                return onAfterRowWasRead;
            }
        }

        //Инициализировать статус выполнения чтения данных
        public void Execute()
        {
            materials = new List<Material>();

            //Если имя файла не указано
            //то
            //вызвать искючение
            if (dataFileName == null || dataFileName.Equals(""))
            {
                throw new Exception("имя файла не указано");
            }

            //Если файл не существует
            //то
            //вызвать искючение
            if (!File.Exists(dataFileName))
            {
                throw new Exception("Файл не существует");
            }


            //Выполнить загрузку
            StreamReader reader = null;
            using (reader = new StreamReader(dataFileName))
            {
                //прочитать файл построчно
                while (!reader.EndOfStream)
                {
                    //Прочитать очередную строку
                    string str = reader.ReadLine();

                    if (onAfterRowWasRead != null)
                        onAfterRowWasRead(str);

                    //получить имя материала первые 20 символов
                    string matname =str.Substring(0,20).Trim();

                    //получить тип материала 1 символ
                    char matType = Char.Parse(str.Substring(20,1));

                    //получить влажность три символа
                    int mathumidity = Int32.Parse(str.Substring(21,3));

                    //получить коэффициент теплопроводимости 5 символов
                    double matcoefficient = Double.Parse(str.Substring(24,5).Trim());

                    //добавить созданный объект материала в список материалов
                    materials.Add(new Material()
                    {
                        name = matname,
                        materialType = matType,
                        humidity = mathumidity,
                        coefficient = matcoefficient
                    }
                    );
                }
            }
        }
    }
}
