using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Product();
            var list = new ProductList();

            var productList = list.dataSplit();
            bool flag = true;

            while(flag)
            {
                System.Console.WriteLine("Inventory Management System");
                System.Console.WriteLine("===================================================");
                System.Console.WriteLine("1. Display Inventory");
                System.Console.WriteLine("2. Add new Item to Inventory");
                System.Console.WriteLine("3. Add new purchase");
                System.Console.WriteLine("4. List Inventory by item type");
                System.Console.WriteLine("5. Exit");
                System.Console.WriteLine("===================================================");
                System.Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        obj.DisplayAll(productList);
                        break;
                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        obj.FetchItemListByType(productList);
                        break;

                    case 5:
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