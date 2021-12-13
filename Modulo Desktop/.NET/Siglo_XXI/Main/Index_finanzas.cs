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
    public partial class Index_finanzas : Form
    {
        public Index_finanzas()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void button_proveedores_Click(object sender, EventArgs e)
        {
            
            AgregarProveedor prov = new AgregarProveedor();
            prov.Show();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordenes ord = new Ordenes();
            ord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarFactura fact = new AgregarFactura();
            fact.Show();
        }
    }
}
