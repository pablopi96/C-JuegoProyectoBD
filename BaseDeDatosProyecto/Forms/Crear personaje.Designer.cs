namespace BaseDeDatosProyecto.Forms
{
    partial class Crear_personaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_personaje));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTiposPers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de personaje:";
            // 
            // cmbTiposPers
            // 
            this.cmbTiposPers.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.cmbTiposPers.FormattingEnabled = true;
            this.cmbTiposPers.Location = new System.Drawing.Point(15, 31);
            this.cmbTiposPers.Name = "cmbTiposPers";
            this.cmbTiposPers.Size = new System.Drawing.Size(441, 27);
            this.cmbTiposPers.TabIndex = 1;
            this.cmbTiposPers.SelectedIndexChanged += new System.EventHandler(this.cmbTiposPers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de personaje:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.textBox1.Location = new System.Drawing.Point(15, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ataque";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Red;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Location = new System.Drawing.Point(18, 307);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(357, 32);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(381, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.BackColor = System.Drawing.Color.Transparent;
            this.lblAtaque.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblAtaque.ForeColor = System.Drawing.Color.Red;
            this.lblAtaque.Location = new System.Drawing.Point(94, 82);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(65, 19);
            this.lblAtaque.TabIndex = 14;
            this.lblAtaque.Text = "Ataque";
            // 
            // lblDefensa
            // 
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.BackColor = System.Drawing.Color.Transparent;
            this.lblDefensa.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblDefensa.ForeColor = System.Drawing.Color.Red;
            this.lblDefensa.Location = new System.Drawing.Point(94, 111);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new System.Drawing.Size(71, 19);
            this.lblDefensa.TabIndex = 16;
            this.lblDefensa.Text = "Defensa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Defensa";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblVida.ForeColor = System.Drawing.Color.Red;
            this.lblVida.Location = new System.Drawing.Point(90, 142);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(45, 19);
            this.lblVida.TabIndex = 18;
            this.lblVida.Text = "Vida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vida";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.Transparent;
            this.lblMana.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblMana.ForeColor = System.Drawing.Color.Red;
            this.lblMana.Location = new System.Drawing.Point(94, 172);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(53, 19);
            this.lblMana.TabIndex = 20;
            this.lblMana.Text = "Maná";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(15, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Maná";
            // 
            // Crear_personaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDefensa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTiposPers);
            this.Controls.Add(this.label1);
            this.Name = "Crear_personaje";
            this.Text = "Crear_personaje";
            this.Load += new System.EventHandler(this.Crear_personaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTiposPers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label label9;
    }
}