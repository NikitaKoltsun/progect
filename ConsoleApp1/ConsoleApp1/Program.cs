using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рзмер массива а:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [n];



            int m = 0;
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i ++)
            {
                a[i] = rnd.Next(1,10);
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i % 2 == 1)
                    m++;
                Console.WriteLine("1");
            }

            int[] b = new int [m];
          
           
            

            for (int i = 0; i <= m; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
