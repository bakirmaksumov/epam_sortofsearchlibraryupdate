using System;
using System.Collections.Generic;
using System.Text;

namespace SortByIndexOfLibrary
{
   public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public bool Equals(Product otherProduct)
        {
            //return true;
            if (otherProduct == null)
            {
                return false;
            }

            return this.Name.Equals(otherProduct.Name);

        }

    }
}
