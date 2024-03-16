using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a^b hesaplayan pr.
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double us, taban;
            Console.WriteLine("sayi tabani giriniz");
            taban=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("us giriniz");
            us = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(taban,us));
            

        }
    }
}
