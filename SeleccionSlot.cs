using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EcapeRoomDigitalPOO.SeleccionSlot;

namespace EcapeRoomDigitalPOO
{
    public partial class SeleccionSlot : Form
    {
        public Partida PartidaSeleccionada { get; private set; }
        public int SlotSeleccionado { get; private set; }
        private Ajustes ajustes;
        private ModoOperacion modo;

        public enum ModoOperacion { Cargar, Guardar }
        public SeleccionSlot(Ajustes ajustesRef, ModoOperacion modoOperacion)
        {
            InitializeComponent();
            this.ajustes = ajustesRef;
            this.modo = modoOperacion;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            ConfigurarInterfaz();
        }

        private void SeleccionSlot_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            ConfigurarInterfaz();
        }
        private void ConfigurarInterfaz()
        {
            lblTitulo.Text = (modo == ModoOperacion.Cargar) ? ajustes.Traducir("TituloCargar") : ajustes.Traducir("TituloGuardar");
            btnSlot1.Text = ObtenerTextoSlot(1);
            btnSlot2.Text = ObtenerTextoSlot(2);
            btnSlot3.Text = ObtenerTextoSlot(3);
            btnVolver.Text = ajustes.Traducir("BtnVolver");

            btnSlot1.Click += BotonSlot_Click;
            btnSlot2.Click += BotonSlot_Click;
            btnSlot3.Click += BotonSlot_Click;
        }

        private string ObtenerTextoSlot(int num)
        {
            if (GestorPersistencia.ExistePartida(num))
            {
                Partida p = GestorPersistencia.Cargar(num);
                return $"Slot {num}: Nivel {p.NivelActual} ({p.PuntajeAcumulado} pts)";
            }
            return $"Slot {num}: [" + ajustes.Traducir("SlotVacio") + "]";
        }

        private void BotonSlot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SlotSeleccionado = int.Parse(btn.Tag.ToString());

            if (modo == ModoOperacion.Cargar)
            {
                if (GestorPersistencia.ExistePartida(SlotSeleccionado))
                {
                    PartidaSeleccionada = GestorPersistencia.Cargar(SlotSeleccionado);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(ajustes.Traducir("AvisoSlotVacioCargar"), ajustes.Traducir("TituloAviso"));
                    return;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}

