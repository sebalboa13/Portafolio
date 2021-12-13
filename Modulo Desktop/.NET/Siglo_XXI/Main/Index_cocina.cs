using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Index_cocina : Form
    {
        public Index_cocina()
        {
            InitializeComponent();
        }

        private void button_plato_Click(object sender, EventArgs e)
        {
            AgregarProducto producto = new AgregarProducto();
            producto.ShowDialog();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_tipo_Click(object sender, EventArgs e)
        {
            TipoProducto tpp = new TipoProducto();
            tpp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar_producto modp = new Modificar_producto();
            modp.Show();
        }
    }
}
