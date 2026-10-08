using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2 
{
    internal class EJE1
    {
        static void Main(string[] args)

        {
            //EJERCICIO N1: Ingrese su edad
            //y si es mayor o igual a 18 años,
            //mostrar "Acceso Permitido",
            //de lo contrario, mostrar "Acceso Denegado".
            //Si el usuario ingresa un valor que no sea un número,
            //mostrar un mensaje de error.
            Console.WriteLine("ingrese su edad:");
           string entrada = Console.ReadLine();

           if (int.TryParse(entrada, out int edad))
           {
               if (edad >= 18)
               {
                   Console.WriteLine("Acceso Permitido");
               }
               else
               {
                   Console.WriteLine("Acceso Denegado");
               }
           }
           else
           {
               Console.WriteLine("ERROR :Por favor ingrese un numero valido la la edad:");
           }

           Console.WriteLine("\nPrecione cualquier tecla para salir..");
           Console.ReadKey();
        }
    }
}
