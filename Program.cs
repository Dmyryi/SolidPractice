using SolidCafe.Models;
using SolidCafe.Order;

public class Program
{
    public static void Main()
    {
        Order order = new Order();

        while (true)
        {
            Console.WriteLine("1.Посмотреть продукты");
            Console.WriteLine("2.Сделать заказ");

            Console.WriteLine("3.Посмотреть корзину");
            Console.WriteLine("4.Способ оплаты");
            Console.WriteLine("5.Получить чек");


            Console.Write("\nВыберите действие: ");
            string chooseOption = Console.ReadLine();

            switch (chooseOption)
            {
                case "1":

                    ProductCatalog catalog = new ProductCatalog();
                    catalog.GetAllProducts();




                    break;
                case "2":
                    order.AddToBucket();
                    break;
                case "3":
                    order.GetBucketAll();
                    break;
                case "4":
                    break;
                case "5":
                    break;

                default:
                    break;
            }
        }
    }
}