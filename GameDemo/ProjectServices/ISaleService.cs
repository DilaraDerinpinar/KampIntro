using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.Entities;

namespace GameDemo.ProjectServices
{
    interface ISaleService
    {
        void Sales(Sale salex);
        void CampaignSales(Sale sales);
    }
}
