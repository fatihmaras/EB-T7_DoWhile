using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            do
            {

                Console.WriteLine(a);
                a++;


            } while (a <= 10);

            Console.WriteLine("\n");


            int b = 1;
            int toplam = 0;

            do
            {
                toplam += b;
                b++;


            } while (b <= 10);

            Console.WriteLine("1'den 10'a kadar olan sayıların Toplamı:" + toplam);
            Console.ReadLine();


        }
    }
}
