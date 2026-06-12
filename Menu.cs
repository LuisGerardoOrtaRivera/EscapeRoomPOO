using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcapeRoomDigitalPOO
{
    public partial class Menu : Form
    {
        private Ajustes ajustes;

        public Menu()
        {
            InitializeComponent();
            ajustes = new Ajustes("idiomas.json");
            this.KeyPreview = true;
            this.KeyDown += Menu_KeyDown;
            AplicarIdioma();

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
        private void cmbIdiomaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdiomaMenu.SelectedIndex == 0) ajustes.CambiarIdioma("es");
            else ajustes.CambiarIdioma("en");
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            btnJugar.Text = ajustes.Traducir("Menu_Jugar");
            btnCargar.Text = ajustes.Traducir("Menu_Cargar");
            btnSalir.Text = ajustes.Traducir("Menu_Salir");
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Partida p = new Partida(1); // Nueva partida en Slot 1
            Form1 j = new Form1(p, this, ajustes);
            j.Show(); this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SeleccionSlot p = new SeleccionSlot(ajustes, SeleccionSlot.ModoOperacion.Cargar))
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    Form1 j = new Form1(p.PartidaSeleccionada, this, ajustes);
                    j.Show(); this.Hide();
                }
            }
        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J) btnJugar.PerformClick();
            else if (e.KeyCode == Keys.C) btnCargar.PerformClick();
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Escape) btnSalir.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
