using System.Collections.Generic;
using Domain;

namespace Application.Products
{
    public interface IList
    {
        public List<Product> GetList();
    }
}