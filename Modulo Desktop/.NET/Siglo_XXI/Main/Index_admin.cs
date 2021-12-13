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
    public partial class Admistrador : Form
    {
        public Admistrador(string nombre)
        {
            InitializeComponent();
            label_nombre.Text = nombre;
        }
        

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void adm_user_Click(object sender, EventArgs e)
        {
            Index_user user = new Index_user();
            user.ShowDialog();
            

        }

        private void button_finanzas_Click(object sender, EventArgs e)
        {
            
            Index_finanzas prov = new Index_finanzas();
            prov.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Index_cocina con = new Index_cocina();
            con.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Index_bodega bod = new Index_bodega();
            bod.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Index_datos dat = new Index_datos();
            dat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            rep.Show();
        }
    }
}
