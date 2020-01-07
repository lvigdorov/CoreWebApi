using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApi.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
