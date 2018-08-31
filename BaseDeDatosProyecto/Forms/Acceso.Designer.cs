namespace BaseDeDatosProyecto.Forms
{
    partial class Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdm
            // 
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdm.Image")));
            this.btnAdm.Location = new System.Drawing.Point(36, 50);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(158, 106);
            this.btnAdm.TabIndex = 0;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJugar.BackgroundImage")));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Maiandra GD", 25F, System.Drawing.FontStyle.Bold);
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(218, 50);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(157, 106);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(36, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(339, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 266);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Acceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}