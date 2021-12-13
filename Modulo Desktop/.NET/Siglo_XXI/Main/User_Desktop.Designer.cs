
namespace Main
{
    partial class User_Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Desktop));
            this.label5 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_contra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.dgvDesktop = new System.Windows.Forms.DataGridView();
            this.button_cargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.label_mensaje = new System.Windows.Forms.Label();
            
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID:";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(176, 118);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(159, 20);
            this.text_id.TabIndex = 21;
            this.text_id.Tag = "";
            // 
            // text_contra
            // 
            this.text_contra.Location = new System.Drawing.Point(176, 236);
            this.text_contra.Name = "text_contra";
            this.text_contra.Size = new System.Drawing.Size(159, 20);
            this.text_contra.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contraseña:";
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(176, 194);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(159, 20);
            this.text_nombre.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre del Trabajador:";
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(176, 157);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(159, 20);
            this.text_username.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(192)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.button_volver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 63);
            this.panel1.TabIndex = 25;
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
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Usuarios Desktop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo Usuario:";
            // 
            // combo_tipo
            // 
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Items.AddRange(new object[] {
            "Admin",
            "Finanzas",
            "Bodega",
            "Cocina"});
            this.combo_tipo.Location = new System.Drawing.Point(176, 275);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(159, 21);
            this.combo_tipo.TabIndex = 28;
            // 
            // dgvDesktop
            // 
            this.dgvDesktop.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDesktop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDesktop.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDesktop.Location = new System.Drawing.Point(0, 324);
            this.dgvDesktop.Name = "dgvDesktop";
            this.dgvDesktop.Size = new System.Drawing.Size(897, 214);
            this.dgvDesktop.TabIndex = 29;
            this.dgvDesktop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesktop_CellContentClick);
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(788, 295);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(88, 23);
            this.button_cargar.TabIndex = 30;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_eliminar.Location = new System.Drawing.Point(390, 197);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 23);
            this.button_eliminar.TabIndex = 32;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(390, 118);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(88, 23);
            this.button_insertar.TabIndex = 34;
            this.button_insertar.Text = "Guardar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(390, 157);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_actualizar.TabIndex = 33;
            this.button_actualizar.Text = "Modificar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // label_mensaje
            // 
            this.label_mensaje.AutoSize = true;
            this.label_mensaje.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.label_mensaje.Location = new System.Drawing.Point(331, 77);
            this.label_mensaje.Name = "label_mensaje";
            this.label_mensaje.Size = new System.Drawing.Size(0, 31);
            this.label_mensaje.TabIndex = 35;
            // 
            // browserView1
            // 
            
            // 
            // User_Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            
            this.Controls.Add(this.label_mensaje);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.dgvDesktop);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.text_contra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Desktop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesktop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_contra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.DataGridView dgvDesktop;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Label label_mensaje;
        
    }
}