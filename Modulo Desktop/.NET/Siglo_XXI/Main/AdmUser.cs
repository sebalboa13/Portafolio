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
    public partial class AdmUser : Form
    {
        public AdmUser()
        {
            InitializeComponent();
            
            this.webBrowser1.Navigate("http://127.0.0.1:8000/admin/auth/user/");
            webBrowser1.ScriptErrorsSuppressed = true;
           
        }

        

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
