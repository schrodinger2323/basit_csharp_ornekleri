using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bolme sonucu kalani bulma
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bolunen, bolen, kalan, sonuc;
            Console.WriteLine("bolunen sayiyi girin ");
            bolunen=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("bolen sayiyi girin ");
            bolen=Convert.ToSingle(Console.ReadLine());
            kalan = bolunen % bolen;
            sonuc = bolunen / bolen;
            Console.WriteLine("kalan= " + kalan);
            Console.WriteLine("sonuc= " + sonuc);
           
        }
    }
}
