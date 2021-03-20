using System.Collections.Generic;
using Domain;
using Persistence;

namespace Application.Products
{
    public class List :IList
    {
        private readonly IDataContext _context;
        public List(IDataContext context)
        {
            _context = context;
        }
        public List<Product> GetList(){
            return _context.Products();
        }
    }
}