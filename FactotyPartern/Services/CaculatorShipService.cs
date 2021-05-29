using FactotyPartern.Constants;
using FactotyPartern.Helper;
using FactotyPartern.Interfaces;
using FactotyPartern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactotyPartern.Services
{
    public class CaculatorShipService: ICaculatorShipService
    {
        public double GetShipFeeByDimension(Product prod)
        {
            return prod.Height * prod.Width * prod.Depth * Coefficient.DIMENTSION_COEFFICIENT;
        }

        public double GetShipFeeByType(Product prod)
        {
            switch (prod.ProductType)
            {
                case 1:
                    return 50000;
                case 2:
                    return 12;
                default:
                    return 0;
            }
        }

        public double GetShipFeeByWeight(Product prod)
        {
            return prod.Weight * Coefficient.WEIGHT_COEFFICIENT;
        }


        public double GetTotalFreeShip(double shipByWeight, double shipByDimension)
        {
            return CaculatorHelper.GetMaxValue(shipByWeight, shipByDimension);
        }

        public double GetTotalFreeShip(double shipByWeight, double shipByDimension, double shipByType)
        {
            return CaculatorHelper.GetMaxValue(shipByWeight, shipByDimension, shipByType);
        }
    }
}
