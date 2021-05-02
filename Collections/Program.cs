using System;
using System.Collections.Generic;

namespace Collections
{
    //4.DERS 20 OCAK 2021
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "Engin", "BERKAY", "Engin", "BERKAY" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Burcu");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
