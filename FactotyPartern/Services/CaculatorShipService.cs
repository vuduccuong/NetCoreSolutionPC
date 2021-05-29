using Shipping.Constants;
using Shipping.Helper;
using Shipping.Interfaces;
using Shipping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    public class CaculatorShipService: ICaculatorShipService
    {
        public double GetShipFeeByDimension(Product prod)
        {
            return prod.Height * prod.Width * prod.Depth * Coefficient.DIMENTSION_COEFFICIENT;
        }

        public double GetShipFeeByWeight(Product prod)
        {
            return prod.Weight * Coefficient.WEIGHT_COEFFICIENT;
        }

        public double GetTotalFreeShip(double shipByWeight, double shipByDimension)
        {
            return CaculatorHelper.GetMaxValue(shipByWeight, shipByDimension);
        }
    }
}
