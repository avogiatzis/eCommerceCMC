namespace Application.Shipping
{
    public class Cost : ICost
    {

        public int CalculateCost(double cost){
            return cost > 50 ? 20:10;
        } 
    }
}