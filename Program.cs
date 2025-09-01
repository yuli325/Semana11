using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"forma", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"niña", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"tema", "point"},
        {"gobierno", "government"},
        {"empresa", "company"},
        {"compañía", "company"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        TraducirFrase();
                        break;
                    case 2:
                        AgregarPalabra();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n==================== MENÚ ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');

        List<string> resultado = new List<string>();

        foreach (string palabra in palabras)
        {
            // Separar signos de puntuación
            string limpia = new string(palabra.Where(char.IsLetter).ToArray()).ToLower();
            string puntuacion = new string(palabra.Where(c => !char.IsLetter(c)).ToArray());

            if (diccionario.ContainsKey(limpia))
            {
                string traducida = diccionario[limpia];
                // Mantener la puntuación
                resultado.Add(traducida + puntuacion);
            }
            else
            {
                resultado.Add(palabra);
            }
        }

        Console.WriteLine("\nTraducción: " + string.Join(" ", resultado));
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en español: ");
        string esp = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la traducción en inglés: ");
        string ing = Console.ReadLine().Trim().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, ing);
            Console.WriteLine($"Palabra agregada: {esp} -> {ing}");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
Subiendo archivo principal del programa
