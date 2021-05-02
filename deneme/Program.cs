using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditService creditManagerTransport = new CreditManagerTransport();
            ICreditService creditManagerMortgage = new CreditManagerMortgage();

            List<ICreditService> listOfCredits = new List<ICreditService> { creditManagerMortgage, creditManagerTransport };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(listOfCredits);
            applicationManager.Oransal(creditManagerMortgage);

            ILoggerService databaseLoggerService = new DatabaseLogger();
            ILoggerService smsLoggerService = new SmsLogger();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService };

            applicationManager.MakeLogAndApplication(creditManagerMortgage, loggers);







            Console.ReadLine();


        }
    }

    interface ICreditService
    {
        void Calculate();
        void Type();
    }


    class CreditManagerTransport : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("%20 faiz oranı var");
        }

        public void Type()
        {
            Console.WriteLine("Taşıt kredisi..");
        }
    }

    class CreditManagerMortgage : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("%40 faiz oranı var");
        }

        public void Type()
        {
            Console.WriteLine("Konut kredisi..");
        }
    }

    class ApplicationManager
    {

        public void MakeApplication(List<ICreditService> credits)
        {
            foreach (var item in credits)
            {
                item.Type();
            }
        }

        public void Oransal(ICreditService credit)
        {
            credit.Calculate();
        }

        public void MakeLogAndApplication(ICreditService credit, List<ILoggerService> loggers)
        {
            credit.Type();
            foreach (var item in loggers)
            {
                item.Log();
            }
        }


    }

    interface ILoggerService
    {
        void Log();
    }


    class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms ile iletildi");
        }
    }

    class DatabaseLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına kayıt edildi");
        }
    }




}
