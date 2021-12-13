
namespace Main
{
    partial class Index_cocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index_cocina));
            this.button_plato = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_tipo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_plato
            // 
            this.button_plato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button_plato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plato.Location = new System.Drawing.Point(61, 105);
            this.button_plato.Name = "button_plato";
            this.button_plato.Size = new System.Drawing.Size(311, 60);
            this.button_plato.TabIndex = 12;
            this.button_plato.Text = "Agregar Plato";
            this.button_plato.UseVisualStyleBackColor = false;
            this.button_plato.Click += new System.EventHandler(this.button_plato_Click);
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.button_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_volver.FlatAppearance.BorderSize = 2;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(18, 21);
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "COCINA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 546);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_tipo
            // 
            this.button_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tipo.Location = new System.Drawing.Point(537, 105);
            this.button_tipo.Name = "button_tipo";
            this.button_tipo.Size = new System.Drawing.Size(311, 60);
            this.button_tipo.TabIndex = 15;
            this.button_tipo.Text = "Agregar Tipo Plato";
            this.button_tipo.UseVisualStyleBackColor = false;
            this.button_tipo.Click += new System.EventHandler(this.button_tipo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Modificar Platos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Index_cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_plato);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index_cocina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index_cocina";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_plato;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tipo;
        private System.Windows.Forms.Button button1;
    }
}