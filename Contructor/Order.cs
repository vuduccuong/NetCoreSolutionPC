using System.Collections.Generic;

namespace Contructor
{
    public class Order {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public List<string> ProductNames { get; set; }
        public Order()
        {
            ProductNames = new List<string>();
        }

        public Order(int id): this()
        {
            this.Id = id;
        }

        public Order(int id, string name): this(id)
        {
            this.OrderName = name;
        }
    }
}
