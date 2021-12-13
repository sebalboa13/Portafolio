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
    public partial class Modificar_producto : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public Modificar_producto()
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
            OracleCommand comando = new OracleCommand("MostrarProductosNew", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvPlato.DataSource = tabla;
            ora.Close();
            this.dgvPlato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvPlato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvPlato.CurrentCell.RowIndex;

            text_id.Text = dgvPlato[0, fila].Value.ToString();
            text_plato.Text = dgvPlato[1, fila].Value.ToString();
            text_precio.Text = dgvPlato[2, fila].Value.ToString();
            text_reseta.Text = dgvPlato[3, fila].Value.ToString();
            label_mensaje.Text = "";
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comandoM = new OracleCommand("ActualizarProductoNew", ora);
                comandoM.CommandType = System.Data.CommandType.StoredProcedure;
                comandoM.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comandoM.Parameters.Add("nomp", OracleType.VarChar).Value = text_plato.Text;
                comandoM.Parameters.Add("prec", OracleType.Number).Value = Convert.ToInt32(text_precio.Text);
                comandoM.Parameters.Add("res", OracleType.VarChar).Value = text_reseta.Text;
                comandoM.ExecuteNonQuery();
                label_mensaje.Text = ("Plato Modificado");
                text_id.Text = "";
                text_plato.Text = "";
                text_precio.Text = "";
                text_reseta.Text = "";

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
                OracleCommand comando = new OracleCommand("EliminarProducto", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comando.ExecuteNonQuery();
                label_mensaje.Text = ("Plato Eliminado");
                text_id.Text = "";
                text_plato.Text = "";
                text_precio.Text = "";
                text_reseta.Text = "";
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
            text_plato.Text = "";
            text_precio.Text = "";
            text_reseta.Text = "";
            label_mensaje.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
    }
}
