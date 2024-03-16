using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//klavyeden girilen sayinin basamak sayisini bulma
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir tam sayi giriniz");
            int num, sayac = 0;
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) { Console.WriteLine(1); }
            else
            {
                if (num < 0) { num = -num; }
                while (num > 0)
                {
                    sayac++;
                    num = num / 10;

                }
                Console.WriteLine(sayac);
            }
        }
       }
 }

