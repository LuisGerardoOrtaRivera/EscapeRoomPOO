namespace EcapeRoomDigitalPOO
{
    partial class FinJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinJuego));
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPuntajeFinal = new System.Windows.Forms.Label();
            this.lblTiempoFinal = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // picEstado
            // 
            this.picEstado.Image = ((System.Drawing.Image)(resources.GetObject("picEstado.Image")));
            this.picEstado.Location = new System.Drawing.Point(264, 40);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(302, 79);
            this.picEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstado.TabIndex = 0;
            this.picEstado.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(321, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(191, 20);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "RESULTADOS FINALES";
            // 
            // lblPuntajeFinal
            // 
            this.lblPuntajeFinal.AutoSize = true;
            this.lblPuntajeFinal.Location = new System.Drawing.Point(260, 210);
            this.lblPuntajeFinal.Name = "lblPuntajeFinal";
            this.lblPuntajeFinal.Size = new System.Drawing.Size(109, 20);
            this.lblPuntajeFinal.TabIndex = 2;
            this.lblPuntajeFinal.Text = "Puntaje Final: ";
            // 
            // lblTiempoFinal
            // 
            this.lblTiempoFinal.AutoSize = true;
            this.lblTiempoFinal.Location = new System.Drawing.Point(260, 248);
            this.lblTiempoFinal.Name = "lblTiempoFinal";
            this.lblTiempoFinal.Size = new System.Drawing.Size(69, 20);
            this.lblTiempoFinal.TabIndex = 3;
            this.lblTiempoFinal.Text = "Tiempo: ";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(260, 287);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(50, 20);
            this.lblProgreso.TabIndex = 4;
            this.lblProgreso.Text = "Nivel: ";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(285, 338);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(98, 36);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(414, 338);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 36);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FinJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.lblTiempoFinal);
            this.Controls.Add(this.lblPuntajeFinal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.picEstado);
            this.Name = "FinJuego";
            this.Text = "FinJuego";
            this.Load += new System.EventHandler(this.FinJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPuntajeFinal;
        private System.Windows.Forms.Label lblTiempoFinal;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnMenu;
    }
}