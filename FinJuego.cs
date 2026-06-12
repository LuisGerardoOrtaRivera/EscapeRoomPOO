using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EcapeRoomDigitalPOO
{
    public partial class FinJuego : Form
    {
        private Form1 juegoActual;
        private Menu menuPrincipal;
        private Ajustes ajustes;

        private string mensajeResultado;
        private int puntajeFinal;
        private int tiempoFinal;
        private int nivelFinal;
        public FinJuego(string mensaje, int puntaje, int tiempo, int nivel, Form1 juego, Menu menu, Ajustes ajustesRef)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            this.mensajeResultado = mensaje;
            this.puntajeFinal = puntaje;
            this.tiempoFinal = tiempo;
            this.nivelFinal = nivel;

            juegoActual = juego; menuPrincipal = menu; ajustes = ajustesRef;

            lblResultado.Text = mensajeResultado; // El mensaje ya viene traducido desde Form1
            lblPuntajeFinal.Text = $"{ajustes.Traducir("LblPuntaje")}: {puntajeFinal}";
            lblTiempoFinal.Text = $"{ajustes.Traducir("LblTiempo")}: {tiempoFinal}";
            lblProgreso.Text = $"{ajustes.Traducir("LblNivel")}: {nivelFinal}/3";

            btnReiniciar.Text = ajustes.Traducir("BtnReiniciar");
            btnMenu.Text = ajustes.Traducir("BtnMenu");
        }
        private void FinJuego_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FinJuego_KeyDown;

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            lblResultado.Text = mensajeResultado;
            lblPuntajeFinal.Text = ajustes.Traducir("LblPuntaje") + ": " + puntajeFinal;
            lblTiempoFinal.Text = ajustes.Traducir("LblTiempo") + ": " + tiempoFinal;
            lblProgreso.Text = ajustes.Traducir("LblNivel") + ": " + nivelFinal + "/3";

            btnReiniciar.Text = ajustes.Traducir("BtnReiniciar");
            btnMenu.Text = ajustes.Traducir("BtnMenu");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Close(); juegoActual.Close();
            Form1 n = new Form1(new Partida(1), menuPrincipal, ajustes);
            n.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); juegoActual.Close(); menuPrincipal.Show();
        }
        private void FinJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R) btnReiniciar.PerformClick(); // R para Reiniciar
            else if (e.KeyCode == Keys.M || e.KeyCode == Keys.Escape) btnMenu.PerformClick(); // M o Esc para Menú
        }
    }
}
