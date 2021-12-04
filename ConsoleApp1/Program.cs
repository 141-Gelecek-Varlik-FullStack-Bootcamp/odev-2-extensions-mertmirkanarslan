using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Yaz Saati Uygulamasına Göre Zaman: " + dateTime);
            //Burada kis saatini dondurecegiz. Bunu yaparken extensionimizi cagiriyoruz.
            Console.WriteLine("Kış Saati Uygulamasına Göre Zaman: " + ClassLibrary1.Extensions.KisSaatiUygulamasi(dateTime));
            //Reflection ile kullanici ismini ekranda gostermek icin:
            Console.WriteLine("Hoşgeldin, " + ClassLibrary1.Extensions.GetDisplayName(UserTypes.type1));
            //Goruntu duzgun olsun diye bir console.readline yapiyorum:
            Console.ReadLine();
        }
    }
}
