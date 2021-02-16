using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.ProjectManagementService;

namespace GameDemo.ProjectServices
{
    interface ICampaignService
    {
        void NewCampaing(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
       



    }
}
