using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenercisCourse
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price {  get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: Argument isn't a Product!");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Name}, {Price}");
            return stringBuilder.ToString();
        }
    }
}