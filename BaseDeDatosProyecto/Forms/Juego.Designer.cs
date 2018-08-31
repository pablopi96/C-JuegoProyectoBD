namespace BaseDeDatosProyecto
{
    partial class Juego
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
            this.txtJuego = new System.Windows.Forms.TextBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEne = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVit = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCoordX = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCoordY = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lstCercanos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtJuego
            // 
            this.txtJuego.Font = new System.Drawing.Font("Maiandra GD", 11F);
            this.txtJuego.Location = new System.Drawing.Point(12, 33);
            this.txtJuego.Multiline = true;
            this.txtJuego.Name = "txtJuego";
            this.txtJuego.Size = new System.Drawing.Size(819, 398);
            this.txtJuego.TabIndex = 0;
            this.txtJuego.TextChanged += new System.EventHandler(this.txtJuego_TextChanged);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblUs.Location = new System.Drawing.Point(12, 9);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(70, 19);
            this.lblUs.TabIndex = 1;
            this.lblUs.Text = "Usuario";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblPer.Location = new System.Drawing.Point(101, 9);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(85, 19);
            this.lblPer.TabIndex = 2;
            this.lblPer.Text = "Personaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label3.Location = new System.Drawing.Point(18, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nivel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblNivel.Location = new System.Drawing.Point(65, 442);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(47, 19);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nivel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label5.Location = new System.Drawing.Point(149, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Experiencia:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblExp.Location = new System.Drawing.Point(239, 442);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(34, 19);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "Exp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label7.Location = new System.Drawing.Point(279, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ataque:";
            // 
            // lblAta
            // 
            this.lblAta.AutoSize = true;
            this.lblAta.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblAta.Location = new System.Drawing.Point(337, 442);
            this.lblAta.Name = "lblAta";
            this.lblAta.Size = new System.Drawing.Size(59, 19);
            this.lblAta.TabIndex = 8;
            this.lblAta.Text = "Ataque";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label9.Location = new System.Drawing.Point(411, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Defensa:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblDef.Location = new System.Drawing.Point(474, 442);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(64, 19);
            this.lblDef.TabIndex = 10;
            this.lblDef.Text = "Defensa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label11.Location = new System.Drawing.Point(555, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Energía:";
            // 
            // lblEne
            // 
            this.lblEne.AutoSize = true;
            this.lblEne.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblEne.ForeColor = System.Drawing.Color.Black;
            this.lblEne.Location = new System.Drawing.Point(613, 442);
            this.lblEne.Name = "lblEne";
            this.lblEne.Size = new System.Drawing.Size(60, 19);
            this.lblEne.TabIndex = 12;
            this.lblEne.Text = "Energía";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label13.Location = new System.Drawing.Point(688, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Vitalidad:";
            // 
            // lblVit
            // 
            this.lblVit.AutoSize = true;
            this.lblVit.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblVit.Location = new System.Drawing.Point(760, 442);
            this.lblVit.Name = "lblVit";
            this.lblVit.Size = new System.Drawing.Size(71, 19);
            this.lblVit.TabIndex = 14;
            this.lblVit.Text = "Vitalidad";
            this.lblVit.Click += new System.EventHandler(this.label14_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(846, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCoordX
            // 
            this.lblCoordX.AutoSize = true;
            this.lblCoordX.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblCoordX.Location = new System.Drawing.Point(302, 9);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(31, 19);
            this.lblCoordX.TabIndex = 19;
            this.lblCoordX.Text = "XX";
            this.lblCoordX.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label16.Location = new System.Drawing.Point(230, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 18;
            this.label16.Text = "Coord X:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label19.Location = new System.Drawing.Point(358, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 19);
            this.label19.TabIndex = 22;
            this.label19.Text = "Coord Y:";
            // 
            // lblCoordY
            // 
            this.lblCoordY.AutoSize = true;
            this.lblCoordY.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.lblCoordY.Location = new System.Drawing.Point(430, 9);
            this.lblCoordY.Name = "lblCoordY";
            this.lblCoordY.Size = new System.Drawing.Size(31, 19);
            this.lblCoordY.TabIndex = 23;
            this.lblCoordY.Text = "XX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(864, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "Más cercanos";
            // 
            // lstCercanos
            // 
            this.lstCercanos.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.lstCercanos.FormattingEnabled = true;
            this.lstCercanos.ItemHeight = 16;
            this.lstCercanos.Location = new System.Drawing.Point(846, 33);
            this.lstCercanos.Name = "lstCercanos";
            this.lstCercanos.Size = new System.Drawing.Size(142, 388);
            this.lstCercanos.TabIndex = 25;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1000, 483);
            this.Controls.Add(this.lstCercanos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCoordY);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblCoordX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblVit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblEne);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.txtJuego);
            this.KeyPreview = true;
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Juego_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJuego;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEne;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblVit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCoordX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCoordY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstCercanos;
    }
}