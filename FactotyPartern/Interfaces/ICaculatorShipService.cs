using FactotyPartern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactotyPartern.Interfaces
{
    public interface ICaculatorShipService
    {
        double GetShipFeeByWeight(Product prod);
        double GetShipFeeByDimension(Product prod);
        double GetShipFeeByType(Product prod);
        double GetTotalFreeShip(double shipByWeight, double shipByDimension);
        double GetTotalFreeShip(double shipByWeight, double shipByDimension, double shipByType);
    }
}
