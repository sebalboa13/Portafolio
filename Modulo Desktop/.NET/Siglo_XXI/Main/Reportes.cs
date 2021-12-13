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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_desktop_Click(object sender, EventArgs e)
        {
            Reporte_stock res = new Reporte_stock();
            res.Show();
        }

        private void button_web_Click(object sender, EventArgs e)
        {
            Reporte_ordenes reo = new Reporte_ordenes();
            reo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_proveedores rep = new Reporte_proveedores();
            rep.Show();
        }
    }
}
