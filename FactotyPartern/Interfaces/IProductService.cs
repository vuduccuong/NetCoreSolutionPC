using FactotyPartern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactotyPartern.Interfaces
{
    public interface IProductService
    {
        double GetPrice(Product product);
        IEnumerable<Product> AllProduct();
    }
}
