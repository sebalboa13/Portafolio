
namespace Main
{
    partial class Index_finanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index_finanzas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_proveedores = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 546);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "FINANZAS";
            // 
            // button_proveedores
            // 
            this.button_proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_proveedores.Location = new System.Drawing.Point(59, 113);
            this.button_proveedores.Name = "button_proveedores";
            this.button_proveedores.Size = new System.Drawing.Size(311, 60);
            this.button_proveedores.TabIndex = 11;
            this.button_proveedores.Text = "Proveedores";
            this.button_proveedores.UseVisualStyleBackColor = false;
            this.button_proveedores.Click += new System.EventHandler(this.button_proveedores_Click);
            // 
            // button_volver
            // 
            this.button_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.button_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_volver.FlatAppearance.BorderSize = 2;
            this.button_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volver.ForeColor = System.Drawing.Color.White;
            this.button_volver.Location = new System.Drawing.Point(12, 12);
            this.button_volver.Margin = new System.Windows.Forms.Padding(0);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(133, 45);
            this.button_volver.TabIndex = 12;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = false;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ordenes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(133)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "Facturas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Index_finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index_finanzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index_finanzas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_proveedores;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}