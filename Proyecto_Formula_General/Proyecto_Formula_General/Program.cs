using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Formula_General
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; 
            double x1 = 0, x2 = 0; 
            Console.Write("Escribe el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escribe el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Escribe el valor de c: ");
            c = int.Parse(Console.ReadLine());
             
            x1 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);  
            x2 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.Write("El valor de x1 es: {0}", x1);
            Console.Write("El valor de x2 es: {0}", x2);
            
            Console.ReadKey(); 
        }
    }
}
