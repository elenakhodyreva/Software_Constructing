using System;
using System.Windows.Forms;
using System.Diagnostics;

using Kpo4381.nmv.Lib;
using Kpo4381.nmv.Main;
using Kpo4381.nmv.Lib.source.my_classes;
using Kpo4381.Lib;

namespace Kpo4381_nmv.Main
{
    public partial class Form1 : Form
    {
       // private List<Material> materialList = null;
        private BindingSource bsMaterials = new BindingSource();
        IMaterialFactory materialFactory;

        MaterialNewLoader_laba4 newLoader;

        public Form1()
        {
            InitializeComponent();

            //Вывести настройки на главную форму
            tbLogPath.Text = AppGlobalSettings.getLogPath;
            tbDataFileName.Text = AppGlobalSettings.getDataFileName;


            //получение объекта фабрики с помощью AppGlobalSettings
            materialFactory = AppGlobalSettings.GetMaterialFactory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                //новое задание
                //IMaterialListLoader loader = new MaterialListTestLoader();
                //loader.Execute();

                //dgvMaterials.DataSource = loader.materialList;

                //загрузка из файла
                //LoadMaterialListCommand fileLoader = new LoadMaterialListCommand(AppGlobalSettings.getDataFileName);

                //интерфейс
                //IMaterialListLoader fileLoader = new MaterialListSplitFileLoader(AppGlobalSettings.getDataFileName);
                //fileLoader.Execute();

                //from test storage
                //bsMaterials.DataSource = loader.getMaterials;

                //from file
                //bsMaterials.DataSource = fileLoader.getMaterials;

                //laba4 from new file
                //newLoader.Execute();

                //для проверки записи в файл исключения
                //throw new NotImplementedException();
                //throw new MyOwnException();
                //throw new MyOwnException("Другое сообщение");

                //using factory
                IMaterialListLoader factoryLoader = materialFactory.CreateMaterialListLoader();
                factoryLoader.Execute();

                

                //laba4 laba6
                newLoader = new MaterialNewLoader_laba4("New_Materials.txt");

                //laba6 указатель на метод передается в сеттер делегата
                newLoader.SetAfterRowWasRead(this.OnAfterRowWasRead);
                newLoader.Execute();


                bsMaterials.DataSource = factoryLoader.getMaterials;
                dgvMaterials.DataSource = bsMaterials;

                
            }
        
            catch( MyOwnException exc)
            {
                MessageBox.Show("Ошибка типа: " + exc.Message);
            }

            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1 " + ex.Message);
                LogUtility.ErrorLog("Ошибка №1 " + ex.Message);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ошибка №2 "+ ex.Message);
            }
        }

        private void mnOpenMaterial_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FrmMaterial frmMaterial = new FrmMaterial();

            Material material = (bsMaterials.Current as Material);

            Console.WriteLine("" + material);
            frmMaterial.SetMaterial(material);

            frmMaterial.ShowDialog();
        
        }

        private void OnAfterRowWasRead(string currentRow)
        {
            Console.WriteLine(currentRow);
        }
    }
}
