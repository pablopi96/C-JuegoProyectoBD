namespace BaseDeDatosProyecto
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 100F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUCU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnJugar.Location = new System.Drawing.Point(598, 135);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(135, 47);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(598, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Instrucciones";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(27, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Registrarse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(598, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(27, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "Login";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(653, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}

