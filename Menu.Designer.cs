namespace EcapeRoomDigitalPOO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.cmbIdiomaMenu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(194, 258);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(101, 46);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(351, 258);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 46);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(507, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picPortada
            // 
            this.picPortada.Image = ((System.Drawing.Image)(resources.GetObject("picPortada.Image")));
            this.picPortada.Location = new System.Drawing.Point(172, 80);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(464, 132);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 4;
            this.picPortada.TabStop = false;
            // 
            // cmbIdiomaMenu
            // 
            this.cmbIdiomaMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomaMenu.FormattingEnabled = true;
            this.cmbIdiomaMenu.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmbIdiomaMenu.Location = new System.Drawing.Point(332, 348);
            this.cmbIdiomaMenu.Name = "cmbIdiomaMenu";
            this.cmbIdiomaMenu.Size = new System.Drawing.Size(143, 28);
            this.cmbIdiomaMenu.TabIndex = 5;
            this.cmbIdiomaMenu.SelectedIndexChanged += new System.EventHandler(this.cmbIdiomaMenu_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIdiomaMenu);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnJugar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.ComboBox cmbIdiomaMenu;
    }
}