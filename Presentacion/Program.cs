using System;
using Aplicacion;
using Dominio;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fabrica = new TransporteFactory();

            Console.WriteLine("=== PATRÓN FACTORY: LOGÍSTICA DE ENVÍOS ===");
            Console.WriteLine("1. Envío Urbano (Moto)");
            Console.WriteLine("2. Envío Regional (Camión)");
            Console.WriteLine("3. Envío Internacional (Avión)");
            Console.Write("Seleccione tipo de envío: ");

            string? opcion = Console.ReadLine();
            ITransporte? transporte = fabrica.CrearTransporte(opcion);

            if (transporte != null)
            {
                transporte.EntregarPedido("Córdoba Capital");
            }
            else
            {
                Console.WriteLine("Opción de transporte no válida.");
            }

            Console.ReadKey();
        }
    }
}
