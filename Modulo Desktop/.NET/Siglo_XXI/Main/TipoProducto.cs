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
    public partial class TipoProducto : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public TipoProducto()
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
            OracleCommand comando = new OracleCommand("MostrarTipoProductos", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvTipo.DataSource = tabla;
            ora.Close();
            this.dgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            

        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("Insertar_Tipo_Producto", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("tipo", OracleType.VarChar).Value = text_tipo.Text;
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Tipo Producto Ingresado");
            }
            catch (Exception)
            {

                label_mensaje.Text = ("Campos Incompletos");
            }
            ora.Close();

        }

        private void dgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            int fila = dgvTipo.CurrentCell.RowIndex;

            text_id.Text = dgvTipo[0, fila].Value.ToString();
            text_tipo.Text = dgvTipo[1, fila].Value.ToString();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comandoM = new OracleCommand("ActualizarTipoProducto", ora);
                comandoM.CommandType = System.Data.CommandType.StoredProcedure;
                comandoM.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comandoM.Parameters.Add("tipo", OracleType.VarChar).Value = text_tipo.Text;
                comandoM.ExecuteNonQuery();
                label_mensaje.Text = ("Tipo Producto Modificado");
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
                OracleCommand comando = new OracleCommand("EliminarTipoProducto", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Tipo Producto Eliminado");
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
            text_tipo.Text = "";
            label_mensaje.Text = "";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
    }
}
