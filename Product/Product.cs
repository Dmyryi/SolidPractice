using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCafe.Product
{
  public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public Category Category { get; private set; }

        public int Portion {  get; private set; }

        public bool IsHot {  get; private set; }

        public Product(string name, int price, Category category, bool isHot) {
            Name = name;
            Price = price;
            Category = category;
            IsHot = isHot;
        }

       
     
    }
}
