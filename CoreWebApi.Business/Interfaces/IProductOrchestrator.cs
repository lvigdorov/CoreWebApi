using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreWebApi.Models;

namespace CoreWebApi.Business.Interfaces
{
    public interface IProductOrchestrator
    {
        Task<ProductModel> GetProduct(int productId);
    }
}
