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
    public partial class Index_user : Form
    {
        public Index_user()
        {
            InitializeComponent();
        }

        private void button_web_Click(object sender, EventArgs e)
        {
            AdmUser admin = new AdmUser();
            admin.ShowDialog();
        }

        private void button_desktop_Click(object sender, EventArgs e)
        {
            User_Desktop des = new User_Desktop();
            des.ShowDialog();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
