using System;

namespace Properties
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var persion = new Persion()
            //{
            //    BirdthDay = new DateTime(1996, 06, 18)
            //};
            //// Trường hợp nào đó thì BirdthDay bị thay đổi chỗ này
            //persion.BirdthDay = new DateTime(1995, 06, 18);



            //=> Sai logic vì thằng persion chỉ có 1 ngày sinh duy nhất
            // => phương thức set phải ở private
            // => sử dụng Contructor
            var persion = new Persion(new DateTime(1996, 06, 18)); // Mỗi thằng người được khởi tạo thì ngày sinh phải là bất biến
            // persion.BirdthDay = new DateTime(1996, 06, 18); => Lỗi vì không thể set được
            // persion.Age = 20; => Lỗi vì thằng này chỉ triển khai get

            Console.WriteLine("Current year is {0} old", persion.Age);
        }
    }
}
