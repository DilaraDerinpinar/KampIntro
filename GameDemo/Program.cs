using System;
using GameDemo.Entities;
using GameDemo.ManagementService;
using GameDemo.ProjectEntities;
using GameDemo.ProjectManagementService;

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
                firstName = "donald", lastName = "george", password = "12345699", birthdate = 1996, id = 2
            };
            CustomerManager customerManager1 = new CustomerManager(new UserValidationManager());

            Customer customer2 = new Customer()
            {
                firstName = "John", lastName = "Degree", password = "123456", id = 1, birthdate = 1999
            };
            CustomerManager customerManager2 = new CustomerManager(new UserValidationManager());
            //******************************************************************************************

            //OYUN OLUŞTURDUM VE OYUNLARDA EKLEME SİLME GÜNCELLEME İŞLEMLERİ YAPTIM:
            Game game1 = new Game()
            {
                gameID = 1, gameName = "among us", gamePrice = 12
            };

            Game game2 = new Game()
            {
                gameID = 2, gameName = "temple run", gamePrice = 10
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
                campaignName = "black friday indirimi", campaignDiscountRate = 30, campaignId = 7
            };

            Campaign campaign2 = new Campaign()
            {
                campaignDiscountRate = 50, campaignName = "Ramazan indirimi", campaignId = 8
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
                game = game1,
                customer = customer1,
                discountedPrice = 8
            };

            Sale sales2 = new Sale()
            {
                game = game2,
                customer = customer2,
                discountedPrice = 6
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
