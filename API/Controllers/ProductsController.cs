using System.Collections.Generic;
using Application.Products;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class ProductsController :BaseAPIController
    {
        private readonly IList _products;
        public ProductsController(IList products)
        {
            _products = products;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts(){
            return _products.GetList();
        }
    }
}