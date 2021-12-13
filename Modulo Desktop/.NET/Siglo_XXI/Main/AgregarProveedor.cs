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
    public partial class AgregarProveedor : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            ora.Open();
            MessageBox.Show("Conectado");
            ora.Close();
        }

        private void button_cargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("MostrarProveedor", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProveedores.DataSource = tabla;
            
            ora.Close();
            this.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void button_insertar_Click(object sender, EventArgs e)
        {


            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("InsertarProveedoresNuevo", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nomp", OracleType.VarChar).Value = text_proveedor.Text;
                comando.Parameters.Add("tel", OracleType.Number).Value = text_telefono.Text;
                comando.Parameters.Add("cor", OracleType.VarChar).Value = text_correo.Text;
                comando.Parameters.Add("nomc", OracleType.VarChar).Value = textnomcon.Text;
                comando.Parameters.Add("reg", OracleType.VarChar).Value = txtregion.Text;
                comando.Parameters.Add("nomb", OracleType.VarChar).Value = texttitular.Text;
                comando.Parameters.Add("ban", OracleType.VarChar).Value = textbanco.Text;
                comando.Parameters.Add("rut", OracleType.Number).Value = textrut.Text;
                comando.Parameters.Add("numc", OracleType.Number).Value = textnumcuenta.Text;
                comando.Parameters.Add("tipc", OracleType.VarChar).Value = txttipocuenta.Text;
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Proveedor Ingresado");

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
                OracleCommand comando = new OracleCommand("ActualizarProveedoresNuevo", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.Parameters.Add("nomp", OracleType.VarChar).Value = text_proveedor.Text;
                comando.Parameters.Add("tel", OracleType.Number).Value = text_telefono.Text;
                comando.Parameters.Add("cor", OracleType.VarChar).Value = text_correo.Text;
                comando.Parameters.Add("nomc", OracleType.VarChar).Value = textnomcon.Text;
                comando.Parameters.Add("reg", OracleType.VarChar).Value = txtregion.Text;

                comando.Parameters.Add("nomb", OracleType.VarChar).Value = texttitular.Text;
                comando.Parameters.Add("ban", OracleType.VarChar).Value = textbanco.Text;
                comando.Parameters.Add("rut", OracleType.Number).Value = textrut.Text;
                comando.Parameters.Add("numc", OracleType.Number).Value = textnumcuenta.Text;
                comando.Parameters.Add("tipc", OracleType.VarChar).Value = txttipocuenta.Text;
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Proveedor Modificado");

                text_id.Text = "";
                text_proveedor.Text = "";
                text_telefono.Text = "";
                text_correo.Text = "";
                textnomcon.Text = "";
                txtregion.Text = "";

                texttitular.Text = "";
                textbanco.Text = "";
                textrut.Text = "";
                textnumcuenta.Text = "";
                txttipocuenta.Text = "";
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("EliminarProveedor", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
            comando.ExecuteNonQuery();
            label_mensaje.Text = ("Proveedor Eliminado");

            text_id.Text = "";
            text_proveedor.Text = "";
            text_telefono.Text = "";
            text_correo.Text = "";
            textnomcon.Text = "";
            txtregion.Text = "";

            texttitular.Text = "";
            textbanco.Text = "";
            textrut.Text = "";
            textnumcuenta.Text = "";
            txttipocuenta.Text = "";

            ora.Close();
        }

        private void Reset()
        {
            text_id.Text = "";
            text_proveedor.Text = "";
            text_telefono.Text = "";
            text_correo.Text = "";
            label_mensaje.Text = "";
            textnomcon.Text = "";
            txtregion.Text = "";

            texttitular.Text = "";
            textbanco.Text = "";
            textrut.Text = "";
            textnumcuenta.Text = "";
            txttipocuenta.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvProveedores.CurrentCell.RowIndex;

            text_id.Text = dgvProveedores[0, fila].Value.ToString();
            text_proveedor.Text = dgvProveedores[1, fila].Value.ToString();
            text_telefono.Text = dgvProveedores[2, fila].Value.ToString();
            text_correo.Text = dgvProveedores[3, fila].Value.ToString();
            textnomcon.Text = dgvProveedores[4, fila].Value.ToString();
            txtregion.Text = dgvProveedores[5, fila].Value.ToString();

            texttitular.Text = dgvProveedores[6, fila].Value.ToString();
            textbanco.Text = dgvProveedores[7, fila].Value.ToString();
            textrut.Text = dgvProveedores[8, fila].Value.ToString();
            textnumcuenta.Text = dgvProveedores[9, fila].Value.ToString();
            txttipocuenta.Text = dgvProveedores[10, fila].Value.ToString();
            this.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            label_mensaje.Text = "";
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
