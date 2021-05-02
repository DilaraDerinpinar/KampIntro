using System;
using GameDemo.Entities;
using GameDemo.Concrete;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye,
            //satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.
            //Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim için önemli değil,
            //kendinize göre mantık geliştirebilirsiniz. 



            //Gereksinimler

            //1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği
            //bir ortamı simule ediniz.Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak
            //doğrulama yapmak istiyoruz. (E - devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.
            //Bunu yapacak servisi simule etmeniz yeterlidir.)

            //2.Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir.
            //Oyuncunun parametre olarak metotta olmasını kastediyorum.)

            //3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

            //4.Satışlarda kampanya entegrasyonunu simule ediniz.

            //************************ PROJECT SOURCE CODE *************************************************//


            //MÜŞTERİ OLUŞTURDUM VE DAHA SONRA MÜŞTERİLERİN KAYITLI OLUP OLMADIKLARINI KONTROL ETTİM//
            Customer customer1 = new Customer()
            {
                FirstName = "donald", LastName = "george", Password = "12345699", Birthdate = 1996, Id = 2
            };
            CustomerManager customerManager1 = new CustomerManager(new UserValidationManager());

            Customer customer2 = new Customer()
            {
                FirstName = "John", LastName = "Degree", Password = "123456", Id = 1, Birthdate = 1999
            };
            CustomerManager customerManager2 = new CustomerManager(new UserValidationManager());
            //******************************************************************************************

            //OYUN OLUŞTURDUM VE OYUNLARDA EKLEME SİLME GÜNCELLEME İŞLEMLERİ YAPTIM:
            Game game1 = new Game()
            {
                GameID = 1, GameName = "among us", GamePrice = 12
            };

            Game game2 = new Game()
            {
                GameID = 2, GameName = "temple run", GamePrice = 10
            };


            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            gameManager.AddGame(game2);
            gameManager.UpdateGame(game1);
            gameManager.DeleteGame(game2);

            //**********************************************************************

            //İNDİRİMLERİ TANIMLADIM VE EKLEME SİLME GÜNCELLEME İŞLEMLERİNİ GERÇEKLEŞTİRDİM
            Campaign campaign1 = new Campaign()
            {
                CampaignName = "black friday indirimi", CampaignDiscountRate = 30, CampaignId = 7
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignDiscountRate = 50, CampaignName = "Ramazan indirimi", CampaignId = 8
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.DeleteCampaign(campaign1);
            campaignManager.NewCampaing(campaign2);
            campaignManager.UpdateCampaign(campaign1);
            campaignManager.UpdateCampaign(campaign2);

            //********************************************************************

            //SATIŞLARI YAPILAN OYUNLARI VE ONU ALAN KİŞİYE DAİR BİLGİLERİ İNDİRİMLİ FİYATI TANIMLADIM.
            //DAHA SONRA SATIŞLARA DAİR BİLGİLERİ TANIMLADIM:
            Sale sales1 = new Sale()
            {
                Game = game1,
                Customer = customer1,
                DiscountedPrice = 8
            };

            Sale sales2 = new Sale()
            {
                Game = game2,
                Customer = customer2,
                DiscountedPrice =  6
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(sales1);
            salesManager.Sales(sales2);
            salesManager.CampaignSales(sales1);
            salesManager.CampaignSales(sales2);

            //*************************************************************

            







        }
    }
}
