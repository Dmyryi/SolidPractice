using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SolidCafe.Models;

namespace SolidCafe.Order
{
    public class Order:IOrderService
    {    
        public int Id { get; set; }
        public decimal TotalPrice { get; set; } = 0;

        public List<Product> bucket =new List<Product>();

        public void AddToBucket()
        {

            while (true)
            {
                Console.WriteLine("Введіть номер продукту (або 0 для завершення): ");
                int chooseProduct;
                while (!int.TryParse(Console.ReadLine(), out chooseProduct))
                {
                    Console.WriteLine("Неправильна кількість");
                    continue;
                }

                if (chooseProduct == 0) break;
               List<Product> products = ProductCatalog.Instance.GetProducts();
                Product selectedProduct = products[chooseProduct - 1];
                Console.WriteLine(selectedProduct.Name);
                bucket.Add(selectedProduct);
                TotalPrice += selectedProduct.Price;
                Console.WriteLine("Addd!1");
            }
        }

        public void GetBucketAll()
        {
            foreach (Product product in bucket) {
                Console.WriteLine($"\n"
                     + $"{product.Name}, " +
                         $"\nЦіна: {product.Price} грн." +
                         $"\nКатегорія: {product.Category}"
                         + $"\n{(product.IsHot ? "Гаряче" : "Холодне")}");
                
            }

            Console.WriteLine("Итоговая сумма: " + TotalPrice);
        }
    }
}
