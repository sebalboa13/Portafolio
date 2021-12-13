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
    public partial class Index_datos : Form
    {
        public Index_datos()
        {
            InitializeComponent();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_proveedores_Click(object sender, EventArgs e)
        {
            detalle_ordenes det = new detalle_ordenes();
            det.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordenes_mesa orm = new Ordenes_mesa();
            orm.Show();
        }
    }
}
