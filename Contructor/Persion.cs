using System;

namespace Contructor
{
    public class Persion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Persion()
        {
        }

        public Persion(int id)
        {
            this.Id = id;
        }

        public Persion(string name)
        {
            var rd = new Random();
            this.Id = rd.Next(1, 1000);
            this.Name = name;
        }
        public Persion(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        protected void GetPersionInfo()
        {
            Console.WriteLine("{0} is {1}", this.Name, this.Id);
        }
    }
}
