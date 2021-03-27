using System;

namespace A133590.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2.");
            Console.Write("Ingrese un texto cualquiera: ");
            string texto = Console.ReadLine();
            Console.WriteLine($"Su texto es: {texto}");
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
