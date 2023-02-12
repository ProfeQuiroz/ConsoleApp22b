using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            do
            {
                Console.WriteLine("Ingrese el primer número");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                n2 = int.Parse(Console.ReadLine());
                if (n1 == n2)
                {
                    Console.WriteLine("Los números ingresados no deben ser iguales");
                }

            } while (n1 == n2);
            if (n1 > n2)
            {
                Console.WriteLine($"El número {n1} es el numero mayor");
                Console.WriteLine($"El número {n2} es el numero menor");
            }
            else
            {
                Console.WriteLine($"El número {n2} es el numero mayor");
                Console.WriteLine($"El número {n1} es el numero menor");
            }
            Console.ReadLine();
        }
    }
}
