using Shipping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Interfaces
{
    public interface IProductService
    {
        double GetPrice(Product product);
        IEnumerable<Product> AllProduct();
    }
}
