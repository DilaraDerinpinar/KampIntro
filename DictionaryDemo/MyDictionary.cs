using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<X>
    {
         X[] items;

         public MyDictionary()
         {
             items = new X[0];
         }

         public void Add(X item)
         {
             X[] tempArray = items;
             items = new X[items.Length + 1];
             for (int i = 0; i < tempArray.Length; i++)
             {
                 items[i] = tempArray[i];
             }
             items[items.Length - 1] = item;

        }

         public int Length
         {
             get { return items.Length; }
         }
         public X[] Items
         {
             get { return items; }
         }


    }
}
