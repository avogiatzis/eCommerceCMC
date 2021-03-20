using Domain;

namespace Application.Orders
{
    public interface ISend
    {
        public int SendOrder(OrderList orders);
    }
}