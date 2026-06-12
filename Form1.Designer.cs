using System.Drawing;

namespace EcapeRoomDigitalPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.btnPista = new System.Windows.Forms.Button();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.picAcertijo = new System.Windows.Forms.PictureBox();
            this.picCuarto = new System.Windows.Forms.PictureBox();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAcertijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            resources.ApplyResources(this.lblPregunta, "lblPregunta");
            this.lblPregunta.Name = "lblPregunta";
            // 
            // lblIntentos
            // 
            resources.ApplyResources(this.lblIntentos, "lblIntentos");
            this.lblIntentos.Name = "lblIntentos";
            // 
            // lblTiempo
            // 
            resources.ApplyResources(this.lblTiempo, "lblTiempo");
            this.lblTiempo.Name = "lblTiempo";
            // 
            // lblPuntaje
            // 
            resources.ApplyResources(this.lblPuntaje, "lblPuntaje");
            this.lblPuntaje.Name = "lblPuntaje";
            // 
            // btnValidar
            // 
            resources.ApplyResources(this.btnValidar, "btnValidar");
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            resources.ApplyResources(this.btnCargar, "btnCargar");
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelOpciones
            // 
            resources.ApplyResources(this.panelOpciones, "panelOpciones");
            this.panelOpciones.Controls.Add(this.rbOpcion4);
            this.panelOpciones.Controls.Add(this.rbOpcion1);
            this.panelOpciones.Controls.Add(this.rbOpcion3);
            this.panelOpciones.Controls.Add(this.rbOpcion2);
            this.panelOpciones.Name = "panelOpciones";
            // 
            // rbOpcion4
            // 
            resources.ApplyResources(this.rbOpcion4, "rbOpcion4");
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // rbOpcion1
            // 
            resources.ApplyResources(this.rbOpcion1, "rbOpcion1");
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            resources.ApplyResources(this.rbOpcion3, "rbOpcion3");
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            resources.ApplyResources(this.rbOpcion2, "rbOpcion2");
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnPista
            // 
            resources.ApplyResources(this.btnPista, "btnPista");
            this.btnPista.Name = "btnPista";
            this.btnPista.UseVisualStyleBackColor = true;
            this.btnPista.Click += new System.EventHandler(this.btnPista_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.AllowDrop = true;
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            resources.ApplyResources(this.cmbIdioma, "cmbIdioma");
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // picAcertijo
            // 
            resources.ApplyResources(this.picAcertijo, "picAcertijo");
            this.picAcertijo.Name = "picAcertijo";
            this.picAcertijo.TabStop = false;
            // 
            // picCuarto
            // 
            resources.ApplyResources(this.picCuarto, "picCuarto");
            this.picCuarto.Name = "picCuarto";
            this.picCuarto.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAcertijo);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.btnPista);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.picCuarto);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAcertijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox picCuarto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.Button btnPista;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.PictureBox picAcertijo;
    }
}

