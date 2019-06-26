using System;
using System.Collections.Generic;

using System.IO;
using Kpo4381.nmv.Lib.source.my_classes;

namespace Kpo4381.nmv.Lib
{
    public delegate void OnLoadFileDelegate(string curentRow);

    public class MaterialNewLoader_laba4 :IMaterialListLoader
    {

        //скрытое поле процедурного типа - делегат
        private OnLoadFileDelegate onAfterRowWasRead;

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


// ***************  делегат ******************************


        private readonly string dataFileName = "";
        private List<Material> materials;
        private LoadStatus loadStatus = LoadStatus.None;

        

        public List<Material> getMaterials { get { return materials; } }
        public LoadStatus getLoadStatus { get { return loadStatus; } }

        public string getFileName { get { return dataFileName; } }

        public MaterialNewLoader_laba4(string fileName)
        {
            dataFileName = fileName;
            materials = new List<Material>();
            onAfterRowWasRead = null;
        }

        




        //этот метод загружает из файла данные о материалах, название,
        //тип, уровень влажности, коэффициент теплопроводности.
        //Данные о материалах сохраняются в объектах класса материал, 
        //а эти объекты в дальнейшем собираются в список данных объектов
        //после сохранения каждого объекта материала, в консоль выводятся сообщения
        //о названии материала и коэффициента теплопроводности
        //Метод возвращает тип void, то есть нет возвращаемого значения


        // Создается объект типа список для дальнейшего сохранения списка материалов

        // Так как в методе идет загрузка из файла, нужно проверить не пустой ли файл
        //если имя файла не указана или переменная не определена, выбросить исключение

        //Проверить, существует ли такой файл. Если нет, также выбросить исключение

        //Начать загрузку данных из файла
        //Отметить, что в конце работы с файлом нужно освободить ресурсы

        // Пока не закончится поток байтов
            // Считывать данные построчно
            // Сохранить строку в отдельную переменную
            // из переменной выделить подстроки в которых хранится название, тип, влажность и коэффициент
            // Тип материала преобразовать в символьный тип,
            //влажность- в целочисленный, коэффициент- в тип с плавающей точкой

            //создать объект типа материал и добавить его в ранее созданный список
            //вывести в консоль название материала и его коэффициент теплопроводности

// **************************************************************************


        //этот метод загружает из файла данные о материалах, название,
        //тип, уровень влажности, коэффициент теплопроводности.
        //Данные о материалах сохраняются в объектах класса материал, 
        //а эти объекты в дальнейшем собираются в список данных обектов
        //после сохранения каждого объекта материала, в консоль выводятся сообщения
        //о названии материала и коэффициента теплопроводности
        //Метод возвращает тип void, то есть нет возвращающего значения
        public void TestPseudoCode()
        {
            // Создается объект типа список для дальнейшего сохранения списка материалов
            materials = new List<Material>();

            // Так как в методе идет загрузка из файла, нужно проверить не пустой ли файл
            //если имя файла не указана или переменная не определена, выбросить исключение
            if (dataFileName == null || dataFileName.Equals(""))
            {
                throw new Exception("имя файла не указано");
            }

            //Проверить, существует ли такой файл. Если нет, также выбросить исключение
            if (!File.Exists(dataFileName))
            {
                throw new Exception("Файл не существует");
            }



            //Начать загрузку данных из файла
            //Отметить, что в конце работы с файлом нужно освободить ресурсы
            StreamReader reader = null;
            using (reader = new StreamReader(dataFileName))
            {
                // Пока не закончится поток байтов
                while (!reader.EndOfStream)
                {
                    // Считывать данные построчно
                    // Сохранить строку в отдельную переменную
                    string str = reader.ReadLine();


                    //получить имя материала первые 20 символов
                    string matname = str.Substring(0, 20).Trim();

                    // Тип материала преобразовать в символьный тип,
                    //влажность- в целочисленный, коэффициент- в тип с плавающей точкой
                   
                    char matType = Char.Parse(str.Substring(20, 1));

                    
                    int mathumidity = Int32.Parse(str.Substring(21, 3));

                    
                    double matcoefficient = Double.Parse(str.Substring(24, 5).Trim());

                    //создать объект типа материал и добавить его в ранее созданный список
                    materials.Add(new Material()
                    {
                        name = matname,
                        materialType = matType,
                        humidity = mathumidity,
                        coefficient = matcoefficient
                    }

                    
                    );
                    //вывести в консоль название материала и его коэффициент теплопроводности
                    Console.WriteLine(matname+", " + matcoefficient);
                }
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
