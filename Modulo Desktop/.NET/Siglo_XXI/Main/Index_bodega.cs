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
    public partial class Index_bodega : Form
    {
        public Index_bodega()
        {
            InitializeComponent();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.ShowDialog();
        }
    }
}
