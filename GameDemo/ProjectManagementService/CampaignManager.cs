
using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.ProjectServices;

namespace GameDemo.ProjectManagementService
{
    class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.campaignName} kampanyası sona erdi!");
        }

        public void NewCampaing(Campaign campaign)
        {
            Console.WriteLine("YENİ KAMPANYAMIZ HAKKINDA");
            Console.WriteLine($"{campaign.campaignName} kampanyası başlıyor!! {campaign.campaignDiscountRate} ye varan indirim fırsatlarını kaçırma!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.campaignName} kampanyasındaki yeni güncelleme! {campaign.campaignDiscountRate} indirim!!");
        }

       
    }
}
