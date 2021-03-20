
using System;
using Xunit;
using Application.Orders;
using Domain;
namespace UnitTests
{
    public class SendTest
    {
        private readonly Send _send;

        public SendTest()
        {
            _send= new Send();
        }

        [Fact]
        public void SendOrder_GivenAnOrder(){
            var orderList=new OrderList();
            var result = _send.SendOrder(orderList);
            Assert.Equal(1, result);
        }
    }
}