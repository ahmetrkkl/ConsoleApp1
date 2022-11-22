using System;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizrOrani = 1.45;
            bool sistemeGirisYaptiMi = true;
            double dolarDun = 18.61;
            double dolarBugun = 18.66;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşit Butonu");
            }

            
            if (sistemeGirisYaptiMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yap Butonu");
            }
            Console.WriteLine (kategoriEtiketi);
        }
    }
}
