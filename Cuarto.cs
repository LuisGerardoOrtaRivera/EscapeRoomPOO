using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcapeRoomDigitalPOO
{
    public class Cuarto
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<Acertijo> Acertijos { get; set; }
        public int Intentos { get; set; }

        public Cuarto(string nombre, string imagen, List<Acertijo> acertijos, int intentos = 5)
        {
            Nombre = nombre;
            Imagen = imagen;
            Acertijos = acertijos;
            Intentos = intentos; // intentos globales por cuarto
        }
    }
}
