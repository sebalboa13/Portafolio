
namespace Main
{
    partial class TipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_tipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_cargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_mensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(897, 69);
            this.panel1.TabIndex = 1;
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.button_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_volver.FlatAppearance.BorderSize = 2;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(9, 11);
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
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Tipo Producto";
            // 
            // text_tipo
            // 
            this.text_tipo.Location = new System.Drawing.Point(181, 175);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(159, 20);
            this.text_tipo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo Producto:";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(181, 141);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(159, 20);
            this.text_id.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            // 
            // dgvTipo
            // 
            this.dgvTipo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTipo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTipo.Location = new System.Drawing.Point(0, 326);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.Size = new System.Drawing.Size(897, 212);
            this.dgvTipo.TabIndex = 18;
            this.dgvTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_CellContentClick);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(414, 141);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(88, 23);
            this.button_insertar.TabIndex = 19;
            this.button_insertar.Text = "Guardar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_eliminar.Location = new System.Drawing.Point(414, 213);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 23);
            this.button_eliminar.TabIndex = 20;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(414, 175);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_actualizar.TabIndex = 21;
            this.button_actualizar.Text = "Modificar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(786, 297);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(88, 23);
            this.button_cargar.TabIndex = 22;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_mensaje
            // 
            this.label_mensaje.AutoSize = true;
            this.label_mensaje.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.label_mensaje.Location = new System.Drawing.Point(329, 82);
            this.label_mensaje.Name = "label_mensaje";
            this.label_mensaje.Size = new System.Drawing.Size(0, 31);
            this.label_mensaje.TabIndex = 36;
            // 
            // TipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.label_mensaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.dgvTipo);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_mensaje;
    }
}