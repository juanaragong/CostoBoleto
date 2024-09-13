using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definicion de Datos
            double costoKilometro, kilometroRecorrer;
            string nombrePasajero;
            int edad;

            double costoBoleto;

            //Entrada
            Console.BackgroundColor = ConsoleColor.Blue; //Cambiar el color de fondo
            Console.WriteLine("APP que calcula el costo de un boleto");
            Console.WriteLine("Dame el nombre del pasajero");
            nombrePasajero = Console.ReadLine();
            Console.WriteLine("Proporciona la edad del pasajero");
            edad=int.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona la cantidad de kilometros por recorrer");
            kilometroRecorrer = double.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el costo por kilometro");
            costoKilometro = double.Parse(Console.ReadLine());
            //Proceso 
            costoBoleto = kilometroRecorrer * costoKilometro;
            //Salida

            Console.ForegroundColor = ConsoleColor.Red;  //Cambiar de color letra
            Console.WriteLine("El pasajero es: " + nombrePasajero);
            Console.WriteLine("Su edad es de: " + edad);
            Console.WriteLine("El costo del boleto es de: " + "$" + costoBoleto);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Proporciona una tecla para salir");
            Console.WriteLine("Ya casi terminamos");
            Console.ReadKey(); //Para ler una tecla 

        }
    }
}
