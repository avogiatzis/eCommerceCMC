using System;
using Xunit;
using Application.Shipping;

namespace UnitTests
{
    public class CostTest

    {

        private readonly Cost _cost;
        public CostTest()
        {
            _cost = new Cost();
        }


        [Fact]
        public void CalculateCost_GivenCostIs40()
        {
            var result = _cost.CalculateCost(40);
            Assert.Equal(10, result);
        }

        [Fact]
        public void CalculateCost_GivenCostIs60()
        {
            var result = _cost.CalculateCost(60);
            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculateCost_GivenCostIs100()
        {
            var result = _cost.CalculateCost(100);
            Assert.Equal(20, result);
        }
    }
}
