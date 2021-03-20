using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class OrderController : BaseAPIController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PostOrder(List<Product> products){
            foreach(var product in products){
                System.Console.WriteLine(product.Name);
            }
            return Ok();
        }
    }
}