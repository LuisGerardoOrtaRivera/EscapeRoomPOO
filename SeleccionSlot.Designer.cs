namespace EcapeRoomDigitalPOO
{
    partial class SeleccionSlot
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
            this.btnSlot1 = new System.Windows.Forms.Button();
            this.btnSlot2 = new System.Windows.Forms.Button();
            this.btnSlot3 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlot1
            // 
            this.btnSlot1.Location = new System.Drawing.Point(205, 113);
            this.btnSlot1.Name = "btnSlot1";
            this.btnSlot1.Size = new System.Drawing.Size(130, 46);
            this.btnSlot1.TabIndex = 0;
            this.btnSlot1.Tag = "1";
            this.btnSlot1.Text = "Slot1";
            this.btnSlot1.UseVisualStyleBackColor = true;
            // 
            // btnSlot2
            // 
            this.btnSlot2.Location = new System.Drawing.Point(205, 184);
            this.btnSlot2.Name = "btnSlot2";
            this.btnSlot2.Size = new System.Drawing.Size(130, 46);
            this.btnSlot2.TabIndex = 1;
            this.btnSlot2.Tag = "2";
            this.btnSlot2.Text = "Slot2";
            this.btnSlot2.UseVisualStyleBackColor = true;
            // 
            // btnSlot3
            // 
            this.btnSlot3.Location = new System.Drawing.Point(205, 246);
            this.btnSlot3.Name = "btnSlot3";
            this.btnSlot3.Size = new System.Drawing.Size(130, 46);
            this.btnSlot3.TabIndex = 2;
            this.btnSlot3.Tag = "3";
            this.btnSlot3.Text = "Slot3";
            this.btnSlot3.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(243, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "label1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(221, 322);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 39);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // SeleccionSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 404);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSlot3);
            this.Controls.Add(this.btnSlot2);
            this.Controls.Add(this.btnSlot1);
            this.Name = "SeleccionSlot";
            this.Text = "SeleccionSlot";
            this.Load += new System.EventHandler(this.SeleccionSlot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlot1;
        private System.Windows.Forms.Button btnSlot2;
        private System.Windows.Forms.Button btnSlot3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
    }
}