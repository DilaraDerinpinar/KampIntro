using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //5.GUN 23 OCAK 2021
        static void Main(string[] args)
        {
            //İNTERFACE CLASSLARI REFERANS EDİYOR:
            ICreditManager creditManagerPF = new CreditManagerPersonalFinance();
            ICreditManager creditManagerTransport = new CreaditManagerTransport();
            ICreditManager creditManagerMortgage = new CreaditManagerMortgage();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new SmsLoggerService(),
                new FileLoggerService(),
                new DatabaseLoggerService(),
            };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new CreditManagerArtisan(), loggers); // polymorphism
            // ihtiyaç kredisi için 3 farklı loglama türünü aynı anda yaptık.
            //Burada creditmanagerartisan i yollama sebebi üstte tanımlanmadı burada bu
            //şekilde tanımlanabilir onu göstermek istedim. istersem onun yerine
            //creditmanagertransport felan da yollayabilirim.

            List<ICreditManager> credits = new List<ICreditManager>() {
                creditManagerPF,
                creditManagerTransport,
                creditManagerMortgage
            };
            // applicationManager.MakeCreditPreview(credits);
        }
    }
}
