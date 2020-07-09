using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProrductId { get; set; }
        public int Quantity{ get; set; }
        public Decimal Price{ get; set; }

        public Product Product { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { get; set; }
    }
}
