using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo.Concrete
{
    class SalesManager:ISaleService
    {
        public void Sales(Sale salex)
        {
            Console.WriteLine($"{salex.Customer.FirstName} adlı kullanıcı {salex.Game.GameName} oyununu {salex.Game.GamePrice} fiyatına almıştır.");
        }

        public void CampaignSales(Sale sales)
        {
            Console.WriteLine($"Sayın kullanıcı {sales.Customer.FirstName}, {sales.Game.GameName} oyununu {sales.DiscountedPrice} indirim ile temin edebilirsiniz");
        }
    }
}
