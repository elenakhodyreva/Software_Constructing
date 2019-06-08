using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        

        public Form1()
        {
            InitializeComponent();

            //Вывести настройки на главную форму
            tbLogPath.Text = AppGlobalSettings.getLogPath;
            tbDataFileName.Text = AppGlobalSettings.getDataFileName;
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
                //throw new NotImplementedException();
                //throw new Exception("Неправильные входные параметры");


                //новое задание
                IMaterialListLoader loader = new MaterialListTestLoader();
                loader.Execute();

                //dgvMaterials.DataSource = loader.materialList;

                //загрузка из файла
                //LoadMaterialListCommand fileLoader = new LoadMaterialListCommand(AppGlobalSettings.getDataFileName);


                //интерфейс
                IMaterialListLoader fileLoader = new MaterialListSplitFileLoader(AppGlobalSettings.getDataFileName);
                fileLoader.Execute();

                //from test storage
                bsMaterials.DataSource = loader.getMaterials;

                //from file
                //bsMaterials.DataSource = fileLoader.getMaterials;
                dgvMaterials.DataSource = bsMaterials;
            }

            //Обработка исключения "Метод не реализован"
            catch(NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1 " + ex.Message);
                LogUtility.ErrorLog("Ошибка №1 " + ex.Message);
            }

            //обработка остальных исключений
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
    }
}
