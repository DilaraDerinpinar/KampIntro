using System;

namespace OOP2
{
    class Program
    {
        //5.GUN 23 OCAK 2021
        static void Main(string[] args)
        {
            ReelCustomer reelCustomer1 = new ReelCustomer();
            reelCustomer1.CustomerNo = 12345;
            reelCustomer1.FullName = "engin demiroğ";
            reelCustomer1.ID = 1;
            reelCustomer1.TcNo = "324353";


            UnrealCustomer unrealCustomer = new UnrealCustomer();
            unrealCustomer.CompanyName = "kodlama.io";
            unrealCustomer.CustomerNo = 1234;
            unrealCustomer.ID = 2;
            unrealCustomer.VergiNo = "3243523";


            Customer reelCustomer2 = new ReelCustomer();
            Customer unrelCustomer2 = new UnrealCustomer();
            //customer hem gerçek hem de tüzel müşterinin referansını tutuyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(reelCustomer1);
            customerManager.Add(reelCustomer2);
            customerManager.Add(unrealCustomer);
            customerManager.Add(unrelCustomer2);


        }
    }
}
