using System.Collections.Generic;
using Domain;

namespace Persistence
{
    public interface IDataContext
    {
        public List<Product> Products();
    }
}