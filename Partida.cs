using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcapeRoomDigitalPOO
{
    public class Partida
    {
        public int NivelActual { get; set; }
        public int PuntajeAcumulado { get; set; }
        public int TiempoTranscurrido { get; set; }
        public int IndiceAcertijo { get; set; }
        public int IntentosRestantes { get; set; }
        public int Slot { get; set; } // Identificador de la ranura (1, 2 o 3)

        public Partida() { } // Necesario para la desincronización JSON

        public Partida(int slot)
        {
            NivelActual = 1;
            PuntajeAcumulado = 0;
            TiempoTranscurrido = 90; // Tiempo inicial por defecto
            IndiceAcertijo = 0;
            IntentosRestantes = 5; // Intentos iniciales por defecto
            Slot = slot;
        }
    }
}

