namespace Contructor
{
    public class MColor {
        public static readonly string _redColor;
        public static readonly string _blueColor;
        public static readonly string _greenColor;

        //Static contructor
        static MColor()
        {
            System.Console.WriteLine("Run contructor");
            _redColor = "Red";
            _blueColor = "Blue";
            _greenColor = "Green";
        }
    }
}
