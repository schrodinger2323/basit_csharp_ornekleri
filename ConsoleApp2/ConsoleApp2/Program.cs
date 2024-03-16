using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//girilen iki sayinin toplamini bulma
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki sayinin toplamini gosterme: ");
            int number1, number2;
            Console.WriteLine("1. sayi: ");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayi: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number2+number1);
            //Console.WriteLine(number1 + " + " + number2 + " = "+Convert.ToInt32(number1+number2));
            Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            //Console.ReadKey();

            Console.Write("\nPress 'Enter' to exit the process...");

            // another use of "Console.ReadKey()" method 
            // here it asks to press the enter key to exit 
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

        }
    }
}
