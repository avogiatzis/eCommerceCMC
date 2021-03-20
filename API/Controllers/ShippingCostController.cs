using Application.Shipping;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ShippingCostController : BaseAPIController
    {
        private readonly ICost _cost;
        public ShippingCostController(ICost cost)
        {
            _cost = cost;
        }

        [HttpGet]
        public ActionResult<int> GetCost(double cost)
        {
            return _cost.CalculateCost(cost);
        }
    }
}