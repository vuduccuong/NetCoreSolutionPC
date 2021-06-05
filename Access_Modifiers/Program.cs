using Contructor;
using System;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            //Không thể sử dụng point.X && Point.Y vì X; Y là private

            var poin2 = new Point(100, 200);
            poin2.GetPoint(); // GetPoint có thuộc tính public nên không hạn chế quyền truy cập

            var persion = new Persion(2, "Vu Duc Cuong");
            //Không truy cập được vào GetPersionInfo() vì đang có thuộc tính protected

            var getset = new GetSet();
            getset.MyText = "Ha ha";
            Console.WriteLine(getset.MyText);

            Console.WriteLine("Hello World!");
        }
    }
}
