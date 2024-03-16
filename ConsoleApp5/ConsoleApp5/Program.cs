using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//klavyeden girilen stringteki kelime sayisini bulan pr.
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir seyler yaziniz");
            string str;
            str= Console.ReadLine();
            int sayac = 1;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] ==' ' )
                {
                    sayac++;
                }

            }
            Console.WriteLine(sayac + " kelime vardir");
            //kelime_sayi_bul();
        }
        static void kelime_sayi_bul()
        {
            Console.WriteLine("string giriniz");
            string s= Console.ReadLine();
            string[] words= s.Split(' ');
            Console.WriteLine("kelime sayisi= " + words.Length);


        }
    }
}
