using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AgregarProducto : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = SYSTEM.,123 ; USER ID = SIGLO_XXI");
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void button_seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog media = new OpenFileDialog();
            media.Filter = "Imagenes|*.jpg; *png";
            media.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            media.Title = "Seleccionar Imagen";

            if (media.ShowDialog() ==DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(media.FileName);
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                ora.Open();

                MemoryStream ms = new MemoryStream();
                pbImagen.Image.Save(ms, ImageFormat.Png);
                byte[] aByte = ms.ToArray();

                OracleCommand comando = new OracleCommand("incertarTest", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = text_nombre.Text;
                comando.Parameters.Add("prec", OracleType.Number).Value = text_precio.Text;
                comando.Parameters.Add("img", OracleType.VarChar).Value = aByte;
                comando.ExecuteNonQuery();
                MessageBox.Show("Test Ingresado");

            }
            catch (Exception)
            {

                MessageBox.Show("Algo Falló");
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("MostrarProductos", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;
            ora.Close();
            this.dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
