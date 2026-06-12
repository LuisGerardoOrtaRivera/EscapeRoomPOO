using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcapeRoomDigitalPOO
{
    public class AcertijoOpciones: Acertijo
    {
        public List<string> Opciones { get; set; }
        public string Pista { get; set; }
        public string ImagenAcertijo { get; set; }

        public AcertijoOpciones(string pregunta, string respuestaCorrecta, List<string> opciones, int intentos, string pista, string imagen)
        {
            Pregunta = pregunta;
            RespuestaCorrecta = respuestaCorrecta;
            Opciones = opciones;
            Intentos = intentos;
            Pista = pista;
            this.ImagenAcertijo = imagen;
        }

        public override bool ValidarRespuesta(string respuesta)
        {
            return Resolver(respuesta);
        }

        public bool Resolver(string respuesta)
        {
            if (string.IsNullOrEmpty(respuesta)) return false;
            return respuesta.Equals(RespuestaCorrecta, StringComparison.OrdinalIgnoreCase);
        }
    }
}

