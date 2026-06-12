using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using EcapeRoomDigitalPOO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EcapeRoomDigitalPOO
{
    public partial class Form1 : Form
    {
        private Menu menuRef;
        private Ajustes ajustes;
        private GestorPartida gestor;
        private Partida partidaActual;

        public Form1(Partida partidaInicial, Menu menuForm, Ajustes ajustesRef)
        {
            InitializeComponent();
            menuRef = menuForm;
            ajustes = ajustesRef;
            partidaActual = partidaInicial;
            gestor = new GestorPartida(partidaActual, ajustes);

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;

            cmbIdioma.Items.Clear();
            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("English");
            

            AplicarIdioma();
            MostrarEstado();
            timer1.Stop(); // Lo paramos por si acaso
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Toda la lógica de inicio se ejecuta aquí
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;

            AplicarIdioma();
            MostrarEstado();
            timer1.Start();
        }
        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedIndex == 0) // Asumiendo 0 = Español, 1 = Inglés
            {
                ajustes.CambiarIdioma("es");
            }
            else
            {
                ajustes.CambiarIdioma("en");
            }

            // 2. ¡MUY IMPORTANTE! Le avisamos al gestor para que traduzca los acertijos actuales
            if (gestor != null)
            {
                gestor.CambiarIdioma(ajustes);
            }

            // 3. Actualizamos toda la interfaz visual
            AplicarIdioma();
            MostrarEstado();
        }

        private void AplicarIdioma()
        {
            btnValidar.Text = ajustes.Traducir("BtnValidar");
            btnCargar.Text = ajustes.Traducir("BtnCargar");
            btnGuardar.Text = ajustes.Traducir("BtnGuardar");
            btnPista.Text = ajustes.Traducir("BtnPista");
            ActualizarLabels();
        }

        private void ActualizarLabels()
        {
            lblPuntaje.Text = $"{ajustes.Traducir("LblPuntaje")}: {gestor.Puntaje}";
            lblIntentos.Text = $"{ajustes.Traducir("LblIntentos")}: {gestor.ObtenerIntentosActual()}";          
            lblTiempo.Text = $"{ajustes.Traducir("LblTiempo")}: {gestor.TiempoRestante}";
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string resp = panelOpciones.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
            if (string.IsNullOrEmpty(resp)) { MessageBox.Show(ajustes.Traducir("Selecciona una opción antes de validar.")); return; }

            var res = gestor.Validar(resp);
            if (res == ResultadoValidacion.Victoria)
            {
                if (gestor.Nivel < gestor.TotalCuartos) { MessageBox.Show(ajustes.Traducir("VictoriaCuarto")); gestor.Nivel++; gestor.CargarNivel(gestor.Nivel); CargarAcertijo(gestor.ObtenerAcertijoActual()); }
                else FinDelJuego(ajustes.Traducir("VictoriaJuego"));
            }
            else if (res == ResultadoValidacion.Derrota) FinDelJuego(ajustes.Traducir("LblResultado"));
            else CargarAcertijo(gestor.ObtenerAcertijoActual());
            MostrarEstado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SeleccionSlot p = new SeleccionSlot(ajustes, SeleccionSlot.ModoOperacion.Guardar))
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    partidaActual.NivelActual = gestor.Nivel; partidaActual.PuntajeAcumulado = gestor.Puntaje;
                    partidaActual.TiempoTranscurrido = gestor.TiempoRestante; partidaActual.IndiceAcertijo = gestor.IndiceAcertijoActual;
                    partidaActual.IntentosRestantes = gestor.ObtenerIntentosActual(); partidaActual.Slot = p.SlotSeleccionado;
                    GestorPersistencia.Guardar(partidaActual);
                    MessageBox.Show($"{ajustes.Traducir("MsjGuardado")} (Slot {partidaActual.Slot})");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (SeleccionSlot p = new SeleccionSlot(ajustes, SeleccionSlot.ModoOperacion.Cargar))
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    Form1 juegoCargado = new Form1(p.PartidaSeleccionada, menuRef, ajustes);
                    juegoCargado.Show(); this.Close();

                    this.FormClosing -= Form1_FormClosing;
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gestor.TiempoRestante > 0)
            {
                gestor.TiempoRestante--;
                lblTiempo.Text = $"{ajustes.Traducir("LblTiempo")}: {gestor.TiempoRestante}";
            }
            else
            {
                timer1.Stop();
                FinDelJuego(ajustes.Traducir("TiempoAgotado"));
            }
        }

        private void MostrarEstado()
        {
            lblPregunta.Text = gestor.ObtenerPreguntaActual();
            ActualizarLabels();
            CargarAcertijo(gestor.ObtenerAcertijoActual());
            try { object img = Properties.Resources.ResourceManager.GetObject(gestor.CuartoActual.Imagen); if (img != null) picCuarto.Image = (Image)img; } catch { }
        }

        private void CargarAcertijo(AcertijoOpciones a)
        {
            if (a == null) return;
            lblPregunta.Text = a.Pregunta;

            // Mezclamos las opciones de forma aleatoria
            var opcionesMezcladas = a.Opciones.OrderBy(x => Guid.NewGuid()).ToList();

            RadioButton[] rbs = { rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4 };

            for (int i = 0; i < rbs.Length && i < opcionesMezcladas.Count; i++)
            {
                rbs[i].Text = opcionesMezcladas[i];
                rbs[i].Checked = false;

                             
            }
            try
            {
                if (!string.IsNullOrEmpty(a.ImagenAcertijo))
                {
                    object img = Properties.Resources.ResourceManager.GetObject(a.ImagenAcertijo);
                    if (img != null) picAcertijo.Image = (Image)img;
                    else picAcertijo.Image = null;
                }
                else
                {
                    picAcertijo.Image = null;
                }
            }
            catch
            {
                picAcertijo.Image = null;
            }
        }

        private void FinDelJuego(string m)
        {
            timer1.Stop();
            FinJuego f = new FinJuego(m, gestor.Puntaje, gestor.TiempoRestante, gestor.Nivel, this, menuRef, ajustes);
            f.ShowDialog();
        }

        private void btnPista_Click(object sender, EventArgs e) { MessageBox.Show(gestor.ObtenerAcertijoActual()?.Pista, ajustes.Traducir("BtnPista")); }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnValidar.PerformClick();
            else if (e.KeyCode == Keys.P) btnPista.PerformClick();
            else if (e.KeyCode == Keys.S) btnGuardar.PerformClick();
            else if (e.KeyCode == Keys.C) btnCargar.PerformClick();

            // --- SELECCIÓN DE OPCIONES CON NÚMEROS (1-4) ---
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) rbOpcion1.Checked = true;
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) rbOpcion2.Checked = true;
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) rbOpcion3.Checked = true;
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) rbOpcion4.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { menuRef.Show(); }
    }

}
