using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Business.Interfaces;
using CoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductOrchestrator _productOrchestrator;

        public ProductsController(IProductOrchestrator productOrchestrator)
        {
            _productOrchestrator = productOrchestrator;
        }


        [HttpGet("{productId}")]
        [Produces(typeof(ProductModel))]
        public async Task<ActionResult> Get(int productId)
        {
            var productModel = await _productOrchestrator.GetProduct(productId);
            return Ok(productModel);
        }

    }
}