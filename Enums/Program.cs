using System;

namespace Enums
{
    
    public enum ShipingMethod
    {
        Grab = 1, // const Grab = 1
        GHN = 2, // const GHN = 2
        GHTK =3, // const GHTK =3
    }

    class Program
    {
        static void Main(string[] args)
        {

            //lấy giá trị
            var method = ShipingMethod.Grab;
            Console.WriteLine("Shiping method is: "+ (int)method);

            //lấy text
            Console.WriteLine(method.ToString());

            //Ví dụ nhận được 1 phương thức giao hàng từ 1 bên thứ 3, muốn xem name phương thức giao hàng
            var methodId = 2;
            Console.WriteLine("Shiping method is: " + (ShipingMethod)methodId);

            //Ví dụ có text ("Grab", "GHN", "GHTK") mà muốn lấy value của phương thức giao hàng
            var methodName = "GHN";
            var myMethod = (ShipingMethod)(Enum.Parse(typeof(ShipingMethod), methodName));

            Console.WriteLine((int)myMethod);
        }

    }
}
