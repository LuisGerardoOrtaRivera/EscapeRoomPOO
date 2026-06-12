using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcapeRoomDigitalPOO
{
    public abstract class Acertijo
    {
        public string Pregunta { get; set; }
        public int Intentos { get; set; }
        public string RespuestaCorrecta { get; set; }
        public abstract bool ValidarRespuesta(string respuesta);
    }
}
