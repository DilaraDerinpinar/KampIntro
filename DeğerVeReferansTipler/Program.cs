﻿using System;

namespace DeğerVeReferansTipler
{
    //3.DERS 16 OCAK 2021
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 yine 30 olur.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999 olur

            //Çünkü değer tipler değerini kendi üzerinde taşır ama referans tipler değeri referans üzerinden hareket ettirir.

        }
    }
}
