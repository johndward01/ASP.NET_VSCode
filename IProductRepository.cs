using System.Collections.Generic;

namespace ASP_NET_VSCode
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}