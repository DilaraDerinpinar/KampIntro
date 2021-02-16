using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.ProjectEntities;
using GameDemo.ProjectServices;

namespace GameDemo.ProjectManagementService
{
    class SalesManager:ISaleService
    {
        public void Sales(Sale salex)
        {
            Console.WriteLine($"{salex.customer.firstName} adlı kullanıcı {salex.game.gameName} oyununu {salex.game.gamePrice} fiyatına almıştır.");
        }

        public void CampaignSales(Sale sales)
        {
            Console.WriteLine($"Sayın kullanıcı {sales.customer.firstName}, {sales.game.gameName} oyununu {sales.discountedPrice} indirim ile temin edebilirsiniz");
        }
    }
}
