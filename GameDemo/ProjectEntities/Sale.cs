using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.ProjectEntities
{
    class Sale
    {
        public Game game { get; set; }
        public Customer customer { get; set; }
        public double discountedPrice { get; set; }


    }
}
