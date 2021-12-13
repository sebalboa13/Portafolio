
namespace Main
{
    partial class AgregarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_proveedor = new System.Windows.Forms.TextBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_cargar = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_mensaje = new System.Windows.Forms.Label();
            this.textnomcon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtregion = new System.Windows.Forms.ComboBox();
            this.txttipocuenta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textnumcuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textrut = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbanco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texttitular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(192)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.button_volver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 66);
            this.panel1.TabIndex = 0;
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.button_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_volver.FlatAppearance.BorderSize = 2;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(9, 9);
            this.button_volver.Margin = new System.Windows.Forms.Padding(0);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(133, 45);
            this.button_volver.TabIndex = 13;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empresa:";
            // 
            // text_proveedor
            // 
            this.text_proveedor.Location = new System.Drawing.Point(144, 167);
            this.text_proveedor.Name = "text_proveedor";
            this.text_proveedor.Size = new System.Drawing.Size(159, 20);
            this.text_proveedor.TabIndex = 2;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(346, 198);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_actualizar.TabIndex = 3;
            this.button_actualizar.Text = "Modificar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProveedores.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 367);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(897, 171);
            this.dgvProveedores.TabIndex = 4;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(144, 208);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(159, 20);
            this.text_telefono.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono:";
            // 
            // text_correo
            // 
            this.text_correo.Location = new System.Drawing.Point(144, 248);
            this.text_correo.Name = "text_correo";
            this.text_correo.Size = new System.Drawing.Size(159, 20);
            this.text_correo.TabIndex = 4;
            this.text_correo.TextChanged += new System.EventHandler(this.text_correo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(346, 159);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(88, 23);
            this.button_insertar.TabIndex = 9;
            this.button_insertar.Text = "Guardar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_eliminar.Location = new System.Drawing.Point(346, 238);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 23);
            this.button_eliminar.TabIndex = 1;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(783, 221);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(75, 23);
            this.button_conectar.TabIndex = 13;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Visible = false;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(770, 338);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(88, 23);
            this.button_cargar.TabIndex = 14;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(144, 132);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(159, 20);
            this.text_id.TabIndex = 5;
            this.text_id.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID:";
            // 
            // label_mensaje
            // 
            this.label_mensaje.AutoSize = true;
            this.label_mensaje.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.label_mensaje.Location = new System.Drawing.Point(323, 69);
            this.label_mensaje.Name = "label_mensaje";
            this.label_mensaje.Size = new System.Drawing.Size(0, 31);
            this.label_mensaje.TabIndex = 36;
            // 
            // textnomcon
            // 
            this.textnomcon.Location = new System.Drawing.Point(144, 288);
            this.textnomcon.Name = "textnomcon";
            this.textnomcon.Size = new System.Drawing.Size(159, 20);
            this.textnomcon.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nombre Contacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Region:";
            // 
            // txtregion
            // 
            this.txtregion.FormattingEnabled = true;
            this.txtregion.Items.AddRange(new object[] {
            "Arica y Parinacota",
            "Tarapacá",
            "Antofagasta",
            "Atacama",
            "Coquimbo",
            "Valparaíso",
            "O\'Higgins",
            "Metropolitana",
            "Maule",
            "Bío Bío",
            "Araucanía",
            "Los Rios",
            "Los Lagos",
            "Aysén",
            "Magallanes"});
            this.txtregion.Location = new System.Drawing.Point(144, 324);
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(159, 21);
            this.txtregion.TabIndex = 40;
            // 
            // txttipocuenta
            // 
            this.txttipocuenta.FormattingEnabled = true;
            this.txttipocuenta.Items.AddRange(new object[] {
            "Ahorro",
            "Corriente",
            "Vista",
            "Rut"});
            this.txttipocuenta.Location = new System.Drawing.Point(566, 319);
            this.txttipocuenta.Name = "txttipocuenta";
            this.txttipocuenta.Size = new System.Drawing.Size(159, 21);
            this.txttipocuenta.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tipo de Cuenta:";
            // 
            // textnumcuenta
            // 
            this.textnumcuenta.Location = new System.Drawing.Point(566, 283);
            this.textnumcuenta.Name = "textnumcuenta";
            this.textnumcuenta.Size = new System.Drawing.Size(159, 20);
            this.textnumcuenta.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Numero de Cuenta:";
            // 
            // textrut
            // 
            this.textrut.Location = new System.Drawing.Point(566, 243);
            this.textrut.Name = "textrut";
            this.textrut.Size = new System.Drawing.Size(159, 20);
            this.textrut.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Rut Titular:";
            // 
            // textbanco
            // 
            this.textbanco.Location = new System.Drawing.Point(566, 203);
            this.textbanco.Name = "textbanco";
            this.textbanco.Size = new System.Drawing.Size(159, 20);
            this.textbanco.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Nombre Banco:";
            // 
            // texttitular
            // 
            this.texttitular.Location = new System.Drawing.Point(566, 162);
            this.texttitular.Name = "texttitular";
            this.texttitular.Size = new System.Drawing.Size(159, 20);
            this.texttitular.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Nombre Titular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(528, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 24);
            this.label13.TabIndex = 51;
            this.label13.Text = "Datos Bancarios";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttipocuenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textnumcuenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textrut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textbanco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.texttitular);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textnomcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_mensaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.text_correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.text_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_proveedor;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox text_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label_mensaje;
        private System.Windows.Forms.TextBox textnomcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtregion;
        private System.Windows.Forms.ComboBox txttipocuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textnumcuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textrut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbanco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox texttitular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}