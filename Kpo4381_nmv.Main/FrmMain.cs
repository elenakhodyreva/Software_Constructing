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

namespace Kpo4381_nmv.Main
{
    public partial class Form1 : Form
    {
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
                throw new NotImplementedException();
                throw new Exception("Неправильные входные параметры");
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
    }
}
