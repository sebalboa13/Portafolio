
namespace Main
{
    partial class Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.button_cargar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.txt_estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(396, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes";
            // 
            // dgvOrden
            // 
            this.dgvOrden.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrden.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrden.Location = new System.Drawing.Point(0, 325);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.Size = new System.Drawing.Size(897, 213);
            this.dgvOrden.TabIndex = 19;
            this.dgvOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellContentClick);
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(787, 296);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(88, 23);
            this.button_cargar.TabIndex = 23;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID:";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(151, 149);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(159, 20);
            this.text_id.TabIndex = 25;
            this.text_id.Tag = "";
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(401, 149);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(88, 23);
            this.button_actualizar.TabIndex = 24;
            this.button_actualizar.Text = "Modificar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.FormattingEnabled = true;
            this.txt_estado.Items.AddRange(new object[] {
            "Pendiente",
            "Entregado",
            "Finalizado"});
            this.txt_estado.Location = new System.Drawing.Point(151, 190);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(159, 21);
            this.txt_estado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado:";
            // 
            // label_mensaje
            // 
            this.label_mensaje.AutoSize = true;
            this.label_mensaje.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.label_mensaje.Location = new System.Drawing.Point(282, 72);
            this.label_mensaje.Name = "label_mensaje";
            this.label_mensaje.Size = new System.Drawing.Size(0, 31);
            this.label_mensaje.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_mensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.ComboBox txt_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mensaje;
        private System.Windows.Forms.Button button1;
    }
}