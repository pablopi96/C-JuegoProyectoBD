namespace BaseDeDatosProyecto
{
    partial class Eleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleccion));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir Personaje:";
            // 
            // cmbPers
            // 
            this.cmbPers.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.cmbPers.FormattingEnabled = true;
            this.cmbPers.Location = new System.Drawing.Point(16, 35);
            this.cmbPers.Name = "cmbPers";
            this.cmbPers.Size = new System.Drawing.Size(493, 27);
            this.cmbPers.TabIndex = 1;
            this.cmbPers.SelectedIndexChanged += new System.EventHandler(this.cmbPers_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(16, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(375, 135);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar personaje";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(357, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Jugar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(375, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Eleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 235);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPers);
            this.Controls.Add(this.label1);
            this.Name = "Eleccion";
            this.Text = "Elegir personaje";
            this.Load += new System.EventHandler(this.Eleccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}