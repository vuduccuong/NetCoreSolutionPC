using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shipping.Interfaces;
using FactotyPartern.Services;
using Microsoft.Extensions.DependencyInjection;
using Shipping.Services;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICaculatorShipService, CaculatorShipService>()
                .AddSingleton<IProductService, ProductService>()
                .BuildServiceProvider();

            var productService = serviceProvider.GetService<IProductService>();
            var products = productService.AllProduct();
            foreach (var prd in products)
            {
                Console.WriteLine($"San pham {prd.ProductName}: ");
                Console.WriteLine($"tong tien : " + productService.GetPrice(prd));
                Console.WriteLine(new String('-',20));
            }

            Console.ReadLine();
        }
    }
}
