﻿using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazlım Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            // array - dizi

            string[] kurslar = new string[] { "Yazlım Geliştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs" , "Java", "Python","C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Döngüsü Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
