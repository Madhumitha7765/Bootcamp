using System;
using System.Collections.Generic;

namespace ProductStore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            int choice;
            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display All Products");
                Console.WriteLine("3. Find Product by ID");
                Console.WriteLine("4. Remove Product by ID");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct(products);
                        break;

                    case 2:
                        DisplayAllProducts(products);
                        break;

                    case 3:
                        FindProductById(products);
                        break;

                    case 4:
                        RemoveProductById(products);
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 5);
        }

        private static void AddProduct(Dictionary<int, Product> products)
        {
            int productId;
            do
            {
                Console.Write("Enter Product ID: ");
                productId = Convert.ToInt32(Console.ReadLine());

                if (products.ContainsKey(productId))
                {
                    Console.WriteLine("Product with the same ID already exists. Enter a different ID.");
                }
                else
                {
                    Product product = new Product();
                    product.prodId = productId;

                    Console.Write("Enter Name: ");
                    product.Name = Console.ReadLine();
                    Console.Write("Enter Manufacturing Date (yyyy-mm-dd): ");
                    product.MfgDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Warranty Date (yyyy-mm-dd): ");
                    product.Warranty = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    product.ProdPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Stock: ");
                    product.ProdStock = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Discount (1-30): ");
                    product.ProdDiscount = Convert.ToSingle(Console.ReadLine());

                    products.Add(productId, product);

                    Console.Write("Do you want to add another product? (yes/no): ");
                }
            } while (Console.ReadLine().Trim().ToLower() == "yes");
        }

        private static void DisplayAllProducts(Dictionary<int, Product> products)
        {
            foreach (var product in products.Values)
            {
                Console.WriteLine(product.Display());
                Console.WriteLine("------------------------------");
            }
        }

        private static void FindProductById(Dictionary<int, Product> products)
        {
            Console.Write("Enter Product ID to find: ");
            int productIdToFind = Convert.ToInt32(Console.ReadLine());

            if (products.TryGetValue(productIdToFind, out Product foundProduct))
            {
                Console.WriteLine(foundProduct.Display());
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        private static void RemoveProductById(Dictionary<int, Product> products)
        {
            Console.Write("Enter Product ID to remove: ");
            int productIdToRemove = Convert.ToInt32(Console.ReadLine());

            if (products.ContainsKey(productIdToRemove))
            {
                products.Remove(productIdToRemove);
                Console.WriteLine($"Product with ID {productIdToRemove} removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
