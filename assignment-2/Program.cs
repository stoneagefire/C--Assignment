using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ProductList();

            var productList = list.dataSplit();

            var product = new Product(productList);

            bool flag = true;

            while(flag)
            {
                System.Console.WriteLine("\nInventory Management System");
                System.Console.WriteLine("===================================================");
                System.Console.WriteLine("1. Display Inventory");
                System.Console.WriteLine("2. Add new Item to Inventory");
                System.Console.WriteLine("3. Add new purchase");
                System.Console.WriteLine("4. List Inventory by item type");
                System.Console.WriteLine("5. Total items in stock.");
                System.Console.WriteLine("5. Exit");
                System.Console.WriteLine("===================================================");
                System.Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        product.DisplayAll(productList);
                        break;
                    case 2:
                        productList = product.AddNewProduct();
                        break;

                    case 3:
                        productList = product.AddNewPurchaseDetail();
                        break;

                    case 4:
                        product.FetchItemListByType();
                        break;

                    case 5:
                        System.Console.WriteLine("\nTotal no. of Items in stock : " + list.totalItems);
                        break;

                    case 6:
                        flag = false;
                        break;

                    default:
                        System.Console.WriteLine("Invalid choice");
                        continue;
                }
            }
        }
    }
}