using Shipping.Helper;
using Shipping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    class ShipFeeByType:CaculatorShipService
    {
        double GetFreeShipByType(double shipByWeight, double shipByDimension, double shipByType)
        {
            return CaculatorHelper.GetMaxValue(shipByWeight, shipByDimension, shipByType);
        }
    }
}
