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
    public partial class Inventario : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public Inventario()
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
            OracleCommand comando = new OracleCommand("MostrarIngredientes2", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvStock.DataSource = tabla;

            ora.Close();
            this.dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("InsertarIngrendiente", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idi", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.Parameters.Add("nom", OracleType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("mar", OracleType.VarChar).Value = textMarca.Text;
                comando.Parameters.Add("can", OracleType.Number).Value = Convert.ToInt32(textCantidad.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Ingrediente Agregado");
                text_id.Text = "";
                textNombre.Text = "";
                textMarca.Text = "";
                textCantidad.Text = "";


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
                OracleCommand comando = new OracleCommand("ActualizarIngrediente", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idi", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.Parameters.Add("nom", OracleType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("mar", OracleType.VarChar).Value = textMarca.Text;
                comando.Parameters.Add("can", OracleType.Number).Value = Convert.ToInt32(textCantidad.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Ingrediente Modificado");
                text_id.Text = "";
                textNombre.Text = "";
                textMarca.Text = "";
                textCantidad.Text = "";
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("EliminarIngrediente", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idi", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Ingrediente Eliminado");
                text_id.Text = "";
                textNombre.Text = "";
                textMarca.Text = "";
                textCantidad.Text = "";
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
            textNombre.Text = "";
            textMarca.Text = "";
            textCantidad.Text = "";
            label_mensaje.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvStock.CurrentCell.RowIndex;

            text_id.Text = dgvStock[0, fila].Value.ToString();
            textNombre.Text = dgvStock[1, fila].Value.ToString();
            textMarca.Text = dgvStock[2, fila].Value.ToString();
            textCantidad.Text = dgvStock[3, fila].Value.ToString();
            label_mensaje.Text = "";

        }
    }

}
