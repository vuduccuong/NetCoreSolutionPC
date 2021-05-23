using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 3, 4, 5, 6, 3, 2 };

            //Độ dài mảng
            var arrLength = numbers.Length;

            //Index của phần tử
            // Nếu không có phần tử đó thì trả về -1
            var indexElement = Array.IndexOf(numbers, 5);

            //Xoá phần tử
            //Lưu ý: Độ dài của mảng không thay đổi,
            // Giá trị tại phần tử đã xoá được set thành giá trị mặc định của kiểu dữ liệu
            Array.Clear(numbers,/*Index bắt đầu*/0, /*Số phần tử muốn xoá*/2);

            //Coppy mảng theo số phần tử chỉ định
            var needNumbers = 3;
            var newArr = new int[needNumbers];
            Array.Copy(numbers, newArr, needNumbers); //Lấy <needNumbers> phần tử đầu tiên của mảng cần coppy

            //Sắp xếp
            Array.Sort(numbers);
        }
    }
}
