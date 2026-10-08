using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese el tipo de cliente (VIP, Frecuente, Nuevo): ");
            string tipoCliente = Console.ReadLine();

            
            tipoCliente = tipoCliente.Trim().ToLower();

            
            Console.Write("Ingrese el monto de la compra: $");
            string entradaMonto = Console.ReadLine();

            
            decimal montoCompra;
            if (!decimal.TryParse(entradaMonto, out montoCompra))
            {
                Console.WriteLine("Error: El monto ingresado no es un número válido.");
                return;
            }

            decimal porcentajeDescuento = 0;
            string mensajeTipo = "";

          
            switch (tipoCliente)
            {
                case "vip":
                    porcentajeDescuento = 0.20m; // 20%
                    mensajeTipo = "Cliente VIP";
                    break;

                case "frecuente":
                    porcentajeDescuento = 0.10m; // 10%
                    mensajeTipo = "Cliente Frecuente";
                    break;

                case "nuevo":
                    porcentajeDescuento = 0.00m; // 0%
                    mensajeTipo = "Cliente Nuevo";
                    break;

                default:
                    
                    Console.WriteLine($"Error: '{tipoCliente}' no es un tipo de cliente válido.");
                    Console.WriteLine("Tipos válidos: VIP, Frecuente, Nuevo");
                    return; 
            }

           
            decimal montoDescuento = montoCompra * porcentajeDescuento;
            decimal precioFinal = montoCompra - montoDescuento;

           
            Console.WriteLine("\n===== RESUMEN DE COMPRA =====");
               Console.WriteLine($"Tipo de cliente:   {mensajeTipo}");
            Console.WriteLine($"Monto original:    ${montoCompra:N2}");
                Console.WriteLine($"Descuento aplicado: {porcentajeDescuento * 100}% (${montoDescuento:N2})");
             Console.WriteLine($"PRECIO FINAL:      ${precioFinal:N2}");
                Console.WriteLine("=============================");

            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
