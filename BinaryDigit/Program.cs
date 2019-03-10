using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigith
{
    class Program
    {
        static void Converte(int n)
        {
            int temp = n % 2;

            if (n >= 2)
            {
                Converte(n / 2);

            }
            Console.Write(temp);
        }
        static void Main(string[] args)
        {
            Console.Write("Write a digit : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Converte(n);
            Console.ReadKey();
        }
    }
}
