using System;

namespace Access_Modifiers
{
    public class Point
    {
        private int X;
        private int Y;

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void GetPoint()
        {
            Console.WriteLine("({0}, {1})", X, Y);
        }
    }
}
