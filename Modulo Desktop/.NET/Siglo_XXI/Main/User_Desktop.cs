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
    public partial class User_Desktop : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public User_Desktop()
        {
            InitializeComponent();
            
        }
        

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("MostrarUserDesktop", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvDesktop.DataSource = tabla;
            ora.Close();
            this.dgvDesktop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("InsertarUserDesktop", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("usern", OracleType.VarChar).Value = text_username.Text;
                comando.Parameters.Add("pass", OracleType.VarChar).Value = text_contra.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = text_nombre.Text;
                comando.Parameters.Add("tip", OracleType.VarChar).Value = combo_tipo.Text;
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Usuario Agregado");
                
                
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ActualizarUserDesktop", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idu", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.Parameters.Add("usern", OracleType.VarChar).Value = text_username.Text;
                comando.Parameters.Add("pass", OracleType.VarChar).Value = text_contra.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = text_nombre.Text;
                comando.Parameters.Add("tip", OracleType.VarChar).Value = combo_tipo.Text;
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Usuario Modificado");
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();
        }

        private void dgvDesktop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvDesktop.CurrentCell.RowIndex;

            text_id.Text = dgvDesktop[0, fila].Value.ToString();
            text_username.Text = dgvDesktop[1, fila].Value.ToString();
            text_contra.Text = dgvDesktop[2, fila].Value.ToString();
            text_nombre.Text = dgvDesktop[3, fila].Value.ToString();
            combo_tipo.Text = dgvDesktop[4, fila].Value.ToString();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("EliminarUserDesktop", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idu", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Usuario Eliminado");
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();
        }

        private void Reset()
        {
            text_id.Text = "";
            text_username.Text = "";
            text_nombre.Text = "";
            text_contra.Text = "";
            combo_tipo.Text = "";
            label_mensaje.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
    }
}
