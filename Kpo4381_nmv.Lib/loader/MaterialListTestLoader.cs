using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.nmv.Lib.source.my_classes;

namespace Kpo4381.nmv.Lib
{
    internal class MaterialListTestLoader: IMaterialListLoader
    {
        private readonly string _dataFileName = "";

        private List<Material> materials;
        private LoadStatus loadStatus = LoadStatus.None;

        public MaterialListTestLoader()
        {
            this.materials = new List<Material>();
        }

        public List<Material> getMaterials { get { return materials; } }
        public LoadStatus getLoadStatus { get { return loadStatus; } }

        public void Execute()
        {
                    materials.Add(new Material() {
                        name = "Алюминий",
                        materialType = 'M',
                        humidity = 100,
                        coefficient = 209.3
                    });
                //}
                //{
                    //Material material = new Material()
                    //{
                    //    name = "Стекловата",
                    //    materialType = 'T',
                    //    humidity = 100,
                    //    coefficient = 0.035
                    //};

                    materials.Add(new Material() {
                        name = "Стекловата",
                        materialType = 'T',
                        humidity = 100,
                        coefficient = 0.035
                    });

                    materials.Add(new Material() {
                        name = "Глина",
                        materialType = 'Д',
                        humidity = 20,
                        coefficient = 0.73
                    });
                }

            
            //catch (NotImplementedException ex)
            //{
            //    LogUtility.ErrorLog("Ошибка №1 " + ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    LogUtility.ErrorLog("Ошибка №2 " + ex.Message);
            //}
        }
    }
