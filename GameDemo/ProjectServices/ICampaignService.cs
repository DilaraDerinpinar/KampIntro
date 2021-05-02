using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.Concrete;

namespace GameDemo.ProjectServices
{
    interface ICampaignService
    {
        void NewCampaing(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
       



    }
}
