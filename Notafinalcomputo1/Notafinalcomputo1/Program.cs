using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notafinalcomputo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio  de obtener la nota final de la materia de Programacion I
            
            //Computo I
            Console.WriteLine("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Parcial1:");
            double Parcial1 = double.Parse(Console.ReadLine());


            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            // C1   = 7.9


            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial1 * 40/ 100;
            Console.WriteLine("La nota de C1 es {0} ", c1);
            //Pausa.
            Console.ReadLine();


            //Computo II

            Console.WriteLine("Lab1: ");
            double Lab1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Lab2: ");
            double Lab2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Parcial2:");
            double Parcial2 = double.Parse(Console.ReadLine());


            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            // C2   = 7.9


            double C2 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es {0} ", C2);
            //Pausa.
            Console.ReadLine();


            //Computo III

            Console.WriteLine("Lab1: ");
            Lab1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Lab2: ");
            Lab2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Parcial3:");
            double Parcial3 = double.Parse(Console.ReadLine());


            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            // C3   = 7.9


            double C3 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial1 * 40 / 100;
            Console.WriteLine("La nota de C3 es {0} ", C3);
            //Pausa.
            Console.ReadLine();


            //Nota Final 
            double notaFinal = (c1 + C2 + C3) / 3;
            Console.WriteLine("La nota final de la materia de Programacion I es {0} ", notaFinal);
            //Pausa.
            Console.ReadLine();



        }
    }
}
