using CoreWebApi.Business.Interfaces;
using CoreWebApi.Business.Mappings;
using CoreWebApi.DataAccess.Entities;
using CoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Business.Orchestrators
{
    public class ProductOrchestrator : IProductOrchestrator
    {
        private readonly SignalRDemoContext _dbContext;

        public ProductOrchestrator(SignalRDemoContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ProductModel> GetProduct(int productId)
        {
            var product = await _dbContext.Products.FindAsync(productId);
            return product.ToModel();
        }
    }
}
