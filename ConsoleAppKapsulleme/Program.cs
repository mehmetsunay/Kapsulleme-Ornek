using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            // ogrencı clasımdan nesne türettim
            Ogrenci ogrenci1 = new Ogrenci();

            // bun nesneye ahmet adını atayabılmek ıcın set ve get methodlarımı cagırıyorum 
            ogrenci1.setIsim("AHMET");
             // if blokları içinde rahat kullanabılmem içinde getı atama ıslemını strıng bır degıskene yapıyorum.
            string gelen = ogrenci1.getIsim();
            // son olarakda aldıgım ısmın aynı olup olmadıgına bakıyorum (buyuk kucuk harf duy.var)
            if(gelen == "AHMET")
            {
                // ve sonuca görede mesaj yazdırıyorum 
                Console.WriteLine("BAŞARILI");

            }

            else
            {

                Console.WriteLine("BAŞARISIZ");
            }

            Console.ReadKey();






        }
    }
}
