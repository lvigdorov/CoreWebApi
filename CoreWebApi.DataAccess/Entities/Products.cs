using System;
using System.Collections.Generic;

namespace CoreWebApi.DataAccess.Entities
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
