using System;
using System.Collections.Generic;

namespace ProductStore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            int choice;
            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product prod = new Product();
                        Console.Write("Enter Product ID: ");
                        prod.prodId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        prod.Name = Console.ReadLine();
                        Console.Write("Enter Manufacturing Date (yyyy-mm-dd): ");
                        prod.MfgDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Warranty Date (yyyy-mm-dd): ");
                        prod.Warranty = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        prod.ProdPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Stock: ");
                        prod.ProdStock = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Discount (1-30): ");
                        prod.ProdDiscount = Convert.ToSingle(Console.ReadLine());

                        products.Add(prod);
                        break;

                    case 2:
                        foreach (Product p in products)
                        {
                            Console.WriteLine(p.Display());
                            Console.WriteLine("------------------------------");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 3);
        }
    }
}
