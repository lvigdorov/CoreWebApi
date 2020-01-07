using CoreWebApi.DataAccess.Entities;
using CoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApi.Business.Mappings
{
    public static class ProductMappings
    {
        public static ProductModel ToModel(this Products product)
        {
            return new ProductModel
            {
                Name = product.Name,
                ProductId = product.ProductId,
                UnitPrice = product.UnitPrice
            };
        }
    }
}
