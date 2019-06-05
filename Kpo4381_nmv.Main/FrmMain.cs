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

namespace Kpo4381_nmv.Main
{
    public partial class Form1 : Form
    {
       // private List<Material> materialList = null;
        private BindingSource bsMaterials = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            
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
                MockMaterialListCommand loader = new MockMaterialListCommand();
                loader.Execute();

                //dgvMaterials.DataSource = loader.materialList;

                bsMaterials.DataSource = loader.materialList;
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
