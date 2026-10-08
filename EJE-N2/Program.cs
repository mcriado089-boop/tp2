using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Solicitar al usuario que ingrese el monto de la compra
            // 2. Leer lo que el usuario escribe (siempre es texto/string)
            // 3. Convertir el texto a un número decimal (para manejar centavos)
            //    Usamos decimal porque es ideal para diner
            // TryParse intenta convertir y devuelve true/false si tuvo éxito
            // 5. Aplicar la lógica principal: ¿El monto es >= 20000?//

            Console.Write("Ingrese el monto de su compra: $");

            
            string entrada = Console.ReadLine();

            decimal montoCompra;

            bool conversionExitosa = decimal.TryParse(entrada, out montoCompra);

         
            if (!conversionExitosa)
            {
                Console.WriteLine("Error: Por favor ingrese un número válido.");
                return;
            }

            
            if (montoCompra >= 20000)
            {
                //  VERDADERAD//
                Console.WriteLine("Tiene envío gratis");
            }
            else
            {
                // FALSA//
                Console.WriteLine("Debe pagar envío");
            }

            // Pausa opcional para ver el resultado en consola
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
