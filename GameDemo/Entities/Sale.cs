using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Entities
{
    class Sale
    {
        public Game Game { get; set; }
        public Customer Customer { get; set; }
        public double DiscountedPrice { get; set; }


    }
}
