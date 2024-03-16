using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//klavyeden girilen iki sayiyi carpan program
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, product;
            Console.WriteLine("1. sayi: ");
            number1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("2. sayi: ");
            number2= Convert.ToSingle(Console.ReadLine());
            product=number1*number2;
            Console.WriteLine(number1 + " * " + number2 + " = " + product);

        }
    }
}
