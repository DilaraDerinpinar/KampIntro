using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("sebnem");
            Console.WriteLine(myDictionary.Length);
            myDictionary.Add("hasan");
            Console.WriteLine(myDictionary.Length);
            myDictionary.Add("ezgi");
            Console.WriteLine(myDictionary.Length);

            foreach (var isim in myDictionary.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
    
}
