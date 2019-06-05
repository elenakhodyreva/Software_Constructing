using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4381.nmv.Lib.source.my_classes;

namespace Kpo4381.nmv.Main
{
    public partial class FrmMaterial : Form
    {
        private Material _material= null;

        public FrmMaterial()
        {
            InitializeComponent();
            _material = null;
        }

        public Material material
        {
            get { return _material; }
        }

        public void SetMaterial(Material material)
        {
            this._material = material;
            this.txtBoxMaterial.Text = _material.coefficient.ToString();
        }
    }
}
