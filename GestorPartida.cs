using EcapeRoomDigitalPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public enum ResultadoValidacion
{
    Continuar,
    Victoria,
    Derrota
}

public class GestorPartida
{
    public int Nivel { get; set; }
    public int Puntaje { get; set; }
    public int TiempoRestante { get; set; }
    public int IndiceAcertijoActual { get; private set; }
    public Cuarto CuartoActual { get; private set; }
    private List<Cuarto> cuartos = new List<Cuarto>();
    public int TotalCuartos => cuartos.Count;
    private Ajustes ajustes;

    public GestorPartida(Partida partida, Ajustes ajustesRef)
    {
        this.ajustes = ajustesRef;
        ConstruirCuartos();
        RestaurarPartida(partida);
    }

    private void ConstruirCuartos()
    {
        cuartos.Clear();
        // Biblioteca
        cuartos.Add(new Cuarto(ajustes.Traducir("Cuarto_Biblioteca"), "biblioteca", new List<Acertijo>
            {
                new AcertijoOpciones(ajustes.Traducir("Biblioteca_Pregunta1"), ajustes.Traducir("Biblioteca_Respuesta1"),
                    new List<string> { ajustes.Traducir("Biblioteca_Opcion1"), ajustes.Traducir("Biblioteca_Opcion2"), ajustes.Traducir("Biblioteca_Opcion3"), ajustes.Traducir("Biblioteca_Opcion4") }, 3, ajustes.Traducir("Biblioteca_Pista1"),"img_csharp"),
                new AcertijoOpciones(ajustes.Traducir("Biblioteca_Pregunta2"), ajustes.Traducir("Biblioteca_Respuesta2"),
                    new List<string> { ajustes.Traducir("Biblioteca_Opcion5"), ajustes.Traducir("Biblioteca_Opcion6"), ajustes.Traducir("Biblioteca_Opcion7"), ajustes.Traducir("Biblioteca_Opcion8") }, 3, ajustes.Traducir("Biblioteca_Pista2"), "img_poo")
            }, 3));
        // Laboratorio
        cuartos.Add(new Cuarto(ajustes.Traducir("Cuarto_Laboratorio"), "laboratorio", new List<Acertijo>
            {
                new AcertijoOpciones(ajustes.Traducir("Laboratorio_Pregunta1"), ajustes.Traducir("Laboratorio_Respuesta1"),
                    new List<string> { ajustes.Traducir("Laboratorio_Opcion1"), ajustes.Traducir("Laboratorio_Opcion2"), ajustes.Traducir("Laboratorio_Opcion3"), ajustes.Traducir("Laboratorio_Opcion4") }, 3, ajustes.Traducir("Laboratorio_Pista1"), "img_cpu"),
                new AcertijoOpciones(ajustes.Traducir("Laboratorio_Pregunta2"), ajustes.Traducir("Laboratorio_Respuesta2"),
                    new List<string> { ajustes.Traducir("Laboratorio_Opcion5"), ajustes.Traducir("Laboratorio_Opcion6"), ajustes.Traducir("Laboratorio_Opcion7"), ajustes.Traducir("Laboratorio_Opcion8") }, 3, ajustes.Traducir("Laboratorio_Pista2"), "img_binario")
            }, 3));
        // Cárcel
        cuartos.Add(new Cuarto(ajustes.Traducir("Cuarto_Carcel"), "carcel", new List<Acertijo>
            {
                new AcertijoOpciones(ajustes.Traducir("Carcel_Pregunta1"), ajustes.Traducir("Carcel_Respuesta1"),
                    new List<string> { ajustes.Traducir("Carcel_Opcion1"), ajustes.Traducir("Carcel_Opcion2"), ajustes.Traducir("Carcel_Opcion3"), ajustes.Traducir("Carcel_Opcion4") }, 3, ajustes.Traducir("Carcel_Pista1"), "img_break"),
                new AcertijoOpciones(ajustes.Traducir("Carcel_Pregunta2"), ajustes.Traducir("Carcel_Respuesta2"),
                    new List<string> { ajustes.Traducir("Carcel_Opcion5"), ajustes.Traducir("Carcel_Opcion6"), ajustes.Traducir("Carcel_Opcion7"), ajustes.Traducir("Carcel_Opcion8") }, 3, ajustes.Traducir("Carcel_Pista2"), "img_trycatch")
            }, 3));
    }

    public void CambiarIdioma(Ajustes nuevosAjustes)
    {
        this.ajustes = nuevosAjustes;
        int n = Nivel; int a = IndiceAcertijoActual; int i = CuartoActual?.Intentos ?? 5;
        ConstruirCuartos();
        Nivel = n; CuartoActual = cuartos[Nivel - 1]; IndiceAcertijoActual = a; CuartoActual.Intentos = i;
    }

    public void CargarNivel(int nivel)
    {
        if (nivel > 0 && nivel <= cuartos.Count) { Nivel = nivel; CuartoActual = cuartos[Nivel - 1]; IndiceAcertijoActual = 0; }
    }

    public ResultadoValidacion Validar(string respuesta)
    {
        var acertijo = (AcertijoOpciones)CuartoActual.Acertijos[IndiceAcertijoActual];
        if (acertijo.ValidarRespuesta(respuesta)) { Puntaje += 10; IndiceAcertijoActual++; return (IndiceAcertijoActual >= CuartoActual.Acertijos.Count) ? ResultadoValidacion.Victoria : ResultadoValidacion.Continuar; }
        else { CuartoActual.Intentos--; return (CuartoActual.Intentos <= 0) ? ResultadoValidacion.Derrota : ResultadoValidacion.Continuar; }
    }

    public AcertijoOpciones ObtenerAcertijoActual() => (IndiceAcertijoActual < CuartoActual.Acertijos.Count) ? (AcertijoOpciones)CuartoActual.Acertijos[IndiceAcertijoActual] : null;
    public string ObtenerPreguntaActual() => ObtenerAcertijoActual()?.Pregunta ?? "";
    public int ObtenerIntentosActual() => CuartoActual?.Intentos ?? 0;

    public void RestaurarPartida(Partida partida)
    {
        Nivel = partida.NivelActual; Puntaje = partida.PuntajeAcumulado; TiempoRestante = partida.TiempoTranscurrido;
        CargarNivel(Nivel); IndiceAcertijoActual = partida.IndiceAcertijo; CuartoActual.Intentos = partida.IntentosRestantes;
    }
}