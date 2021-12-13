using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");

        public void logear(string usuario, string contra)
        {

            try
            {
                conexion.Open();
                OracleCommand cmd = new OracleCommand("SELECT NOMBRE, TIPO_USUARIO FROM MAIN_USUARIOS_DESKTOP WHERE USERNAME = :usuario AND PASSWORD = :pas", conexion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contra);
                OracleDataAdapter sda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    Login ss = new Login();

                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        this.Hide();
                        new Admistrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        label_error.Text = "Usted NO es un usuario 'Administrador'";
                    }
                    else if (dt.Rows[0][1].ToString() == "Bodega")
                    {
                        label_error.Text = "Usted NO es un usuario 'Administrador'";
                    }
                    else if (dt.Rows[0][1].ToString() == "Cocina")
                    {
                        label_error.Text = "Usted NO es un usuario 'Administrador'";
                    }
                    else if (dt.Rows[0][1].ToString() == "Finanzas")
                    {
                        label_error.Text = "Usted NO es un usuario 'Administrador'";
                    }


                }
                else
                {
                    label_error.Text = "    Usuario y/o Contraseña Incorrectas";

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }






        }

        private void button_login_Click(object sender, EventArgs e)
        {
            logear(this.txt_usuario.Text, this.txt_password.Text);
        }
    }
}
