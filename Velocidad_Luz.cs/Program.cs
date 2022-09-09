using System;
namespace Velocidad_Luz.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tiempo en segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            int kilometros, millas, dato1, dato2;

            segundos = 3600;
            millas=1852;
            kilometros=27777778;

            dato1 = segundos * kilometros;
            dato2 = segundos * millas;

            Console.WriteLine("Distancia en Kilometros: " + Convert.ToDecimal(segundos/kilometros));
            Console.WriteLine("Distancia en Millas Nauticas: " + Convert.ToDecimal(segundos/millas));

            Console.ReadKey();


        }
    }
}
