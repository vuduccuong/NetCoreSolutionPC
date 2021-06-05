using System;

namespace Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var persion1 = new Persion();
            persion1.Id = 1;
            persion1.Name = "CuongVD";

            var persion2 = new Persion(1);
            persion2.Id = 4;

            var persion3 = new Persion("CuongVD3");

            var persion4 = new Persion(4, "CuongVD4");

            //Hoặc Initial object
            var persion5 = new Persion
            {
                Id = 5,
                Name = "CuongVD5"
            };

            Console.WriteLine("{0} {1}", persion1.Name, persion1.Id);
            Console.WriteLine("{0} {1}", persion2.Name, persion2.Id);
            Console.WriteLine("{0} {1}", persion3.Name, persion3.Id);
            Console.WriteLine("{0} {1}", persion4.Name, persion4.Id);
            Console.WriteLine("{0} {1}", persion5.Name, persion5.Id);

            //Order
            var order1 = new Order();
            var order2 = new Order(1);

            Console.WriteLine("{0} {1}", order1.OrderName, order1.Id);
            Console.WriteLine("{0} {1} {2}", order2?.OrderName, order2?.Id, order2.ProductNames);

            //Static contructor
            var color1 = MColor._redColor;
            var color2 = MColor._blueColor;

            Console.WriteLine("color is: {0}, {1}", color1, color2);
        }
    }
}
