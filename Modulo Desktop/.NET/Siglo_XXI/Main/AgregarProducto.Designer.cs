
namespace Main
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            this.button_seleccionar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.button_cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(104, 42);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(145, 20);
            this.text_id.TabIndex = 1;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(104, 83);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(145, 20);
            this.text_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(104, 126);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(145, 20);
            this.text_precio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // opdSeleccionar
            // 
            this.opdSeleccionar.FileName = "media";
            // 
            // button_seleccionar
            // 
            this.button_seleccionar.Location = new System.Drawing.Point(63, 348);
            this.button_seleccionar.Name = "button_seleccionar";
            this.button_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_seleccionar.TabIndex = 7;
            this.button_seleccionar.Text = "Seleccionar";
            this.button_seleccionar.UseVisualStyleBackColor = true;
            this.button_seleccionar.Click += new System.EventHandler(this.button_seleccionar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(212, 348);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 8;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(915, 480);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("http://127.0.0.1:8000/addProductos", System.UriKind.Absolute);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(63, 178);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(224, 166);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.Green;
            this.button_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_volver.FlatAppearance.BorderSize = 2;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Location = new System.Drawing.Point(9, 9);
            this.button_volver.Margin = new System.Windows.Forms.Padding(0);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 13;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(192)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 62);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(5, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registro de Platos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductos.Location = new System.Drawing.Point(0, 528);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(897, 10);
            this.dgvProductos.TabIndex = 15;
            this.dgvProductos.Visible = false;
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(762, 457);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(88, 23);
            this.button_cargar.TabIndex = 16;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Visible = false;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_seleccionar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog opdSeleccionar;
        private System.Windows.Forms.Button button_seleccionar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button1;
    }
}