
using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} kampanyası sona erdi!");
        }

        
        public void NewCampaing(Campaign campaign)
        {
            Console.WriteLine("YENİ KAMPANYAMIZ HAKKINDA");
            Console.WriteLine($"{campaign.CampaignName} kampanyası başlıyor!! {campaign.campaignDiscountRate} ye varan indirim fırsatlarını kaçırma!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} kampanyasındaki yeni güncelleme! {campaign.campaignDiscountRate} indirim!!");
        }

       

        
    }
}
