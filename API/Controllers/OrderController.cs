
using Application.Orders;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class OrderController : BaseAPIController
    {
        private readonly ISend _send;
        public OrderController(ISend send)
        {
            _send = send;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PostOrder(OrderList orders)
        {
            return Ok(_send.SendOrder(orders));
        }
    }
}