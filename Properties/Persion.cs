using System;

namespace Properties
{
    public class Persion
    {
        private const int DAY_OF_YEAR = 365;

        public Persion(DateTime birdthDay)
        {
            BirdthDay = birdthDay;
        }
        public DateTime BirdthDay { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirdthDay;
                var year = timeSpan.Days / DAY_OF_YEAR;
                return year;
            }
        }
    }
}
