using System;

namespace RefAndOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * a bir değer tiptir. Calculate metodunda gönderdiğimizde değeri 6 olarak değiştirilmek istense de yine 7 olarak kalır.
             * Eğer metod içerisinde değişmesini istiyorsak ref keywordünü kullanırız. Ancak bunun için en başta değerin set edilmesi
             * gerekir.
             *
             *
             * out keywordünde ise en başta değerin set edilmesi zorunlu değildir. metod içerisinde de halledilebilir.
             */

            //int a=7;
            int b;
            int c=8;
            //Calculate(ref a,b);
            Calculate2(out b,c);
            Console.ReadLine();
        }

        //public static void Calculate(ref int x,int y)
        //{
        //    x = 6; 
        //    Console.WriteLine(x+y);
        //}
        public static void Calculate2(out int y, int z)
        {
            y = 19;
            Console.WriteLine(y+z);
        }
    }
}
