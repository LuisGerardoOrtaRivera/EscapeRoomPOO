using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcapeRoomDigitalPOO
{
    public class Ajustes
    {
        private Dictionary<string, Dictionary<string, string>> traducciones;
        private string idiomaActual = "es";

        public Ajustes(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    throw new FileNotFoundException($"No se encontró el archivo de idiomas: {rutaArchivo}");
                }

                string json = File.ReadAllText(rutaArchivo);
                traducciones = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);

                if (traducciones == null)
                    throw new Exception("El archivo de idiomas está vacío o mal formado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar idiomas: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Inicializar diccionario vacío para evitar NullReferenceException
                traducciones = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        public void CambiarIdioma(string idioma)
        {
            if (traducciones.ContainsKey(idioma))
                idiomaActual = idioma;
        }

        public string Traducir(string clave)
        {
            try
            {
                if (traducciones.ContainsKey(idiomaActual) && traducciones[idiomaActual].ContainsKey(clave))
                    return traducciones[idiomaActual][clave];
            }
            catch { /* Fallback al valor de la clave */ }

            return clave;
        }
    }
}
