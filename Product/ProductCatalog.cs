using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCafe.Product
{
    public class ProductCatalog
    {
   
        private List<Product> products = new List<Product> {
            new("Салат", 10, Category.Food, false),
            new("Кола", 5, Category.Drink,  false),
            new("Кофе", 5, Category.Drink, true),
    



        };
        public List<Product> bucket = new List<Product>();


        public void  GetAllProducts()
        {
            for(int i = 0; i < products.Count;)
            {
                Console.WriteLine($"\n{i+1}."
                +$"{products[i].Name}, " +
                    $"\nЦіна: {products[i].Price} грн."+
                    $"\nКатегорія: {products[i].Category}"
                    +$"\n{(products[i].IsHot ? "Гаряче" : "Холодне")}");
                i++;
            }
        }

   
    }
}
