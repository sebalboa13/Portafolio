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
    public partial class Ordenes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public Ordenes()
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
            OracleCommand comando = new OracleCommand("MostrarOrdenesNew", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvOrden.DataSource = tabla;
            ora.Close();
            this.dgvOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvOrden.CurrentCell.RowIndex;

            text_id.Text = dgvOrden[0, fila].Value.ToString();
            txt_estado.Text = dgvOrden[4, fila].Value.ToString();
            label_mensaje.Text = "";
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comandoM = new OracleCommand("ActualizarEstado", ora);
                comandoM.CommandType = System.Data.CommandType.StoredProcedure;
                comandoM.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(text_id.Text);
                comandoM.Parameters.Add("est", OracleType.VarChar).Value = txt_estado.Text;
                comandoM.ExecuteNonQuery();
                label_mensaje.Text = ("Estado Orden Modificado");
                text_id.Text = "";
                txt_estado.Text = "";
                
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
            txt_estado.Text = "";
            label_mensaje.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
    }


}
