using Shipping.Interfaces;
using Shipping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactotyPartern.Services
{

    class ProductService : IProductService
    {
        private readonly ICaculatorShipService _shipService;
        public ProductService(ICaculatorShipService shipService)
        {
            _shipService = shipService;
        }
        public IEnumerable<Product> AllProduct()
        {

            return new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    ProductName = "Samsung s21",
                    ProductType = 1,
                    Width = 30,
                    Height = 7,
                    Depth = 5,
                    Weight = 5,
                    OriginalPrice = 2000
                },
                new Product
                {
                    Id = 2,
                    ProductName = "IPhone 14",
                    ProductType = 2,
                    Width = 30,
                    Height = 7,
                    Depth = 5,
                    Weight = 5,
                    OriginalPrice = 3000
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Container",
                    ProductType = 2,
                    Width = 30,
                    Height = 7,
                    Depth = 5,
                    Weight = 2000,
                    OriginalPrice = 3000
                }
            };
        }

        public double GetPrice(Product product)
        {
            var shipByWeiht = _shipService.GetShipFeeByWeight(product);
            var shipByDimension = _shipService.GetShipFeeByDimension(product);

            var totalShip = _shipService.GetTotalFreeShip(shipByWeiht, shipByDimension);

            Console.WriteLine($"Gia goc = {product.OriginalPrice}");
            Console.WriteLine($"Gia ship = {totalShip}");
            return product.OriginalPrice + totalShip;
        }
    }
}
