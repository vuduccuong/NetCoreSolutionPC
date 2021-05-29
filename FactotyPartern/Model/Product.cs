using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductType { get; set; }
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double OriginalPrice { get; set; }
    } 
}
