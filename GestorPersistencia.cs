using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcapeRoomDigitalPOO
{
    public static class GestorPersistencia
    {
        private static string ObtenerRuta(int slot) => $"partida_{slot}.json";

        public static void Guardar(Partida partida)
        {
            try
            {
                string json = JsonSerializer.Serialize(partida, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ObtenerRuta(partida.Slot), json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo guardar la partida en el slot {partida.Slot}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static Partida Cargar(int slot)
        {
            try
            {
                string ruta = ObtenerRuta(slot);
                if (!File.Exists(ruta)) return null;

                string json = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<Partida>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la partida del slot {slot}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        public static bool ExistePartida(int slot)
        {
            return File.Exists(ObtenerRuta(slot));
        }
    }
}


