using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Product
    {
        List<List<string>> productList;
        public Product(List<List<string>> productList)
        {
            this.productList = productList;
        }
        public List<string> getData()
        {
            var data = new List<string>();

            System.Console.WriteLine("Enter Product Name: ");
            data.Add(Console.ReadLine());

            System.Console.WriteLine("Enter Product Value: ");
            data.Add(Console.ReadLine());

            System.Console.WriteLine("Enter Product Quantity: ");
            data.Add(Console.ReadLine());

            System.Console.WriteLine("Enter Product Type: ");
            data.Add(Console.ReadLine());

            return data;
        }

        public List<List<string>> AddNewProduct()
        {
            System.Console.WriteLine("Enter no. of new products to add in inventry: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tempData = getData();
                productList.Add(tempData);
                System.Console.WriteLine("\nNew item added to Inventory...\n");
            }
            return productList;
        }

        internal void FetchItemListByType()
        {
            string[] itemTypeList = { "Leafy green", "Cruciferous", "Marrow", "Root" };
            System.Console.WriteLine("available Item type :");
            foreach (string itemType in itemTypeList)
            {
                System.Console.Write(itemType + ", ");
            }
            System.Console.Write("\nEnter item type: ");
            string inputType = Console.ReadLine();

            foreach (string itemType in itemTypeList)
            {
                if (inputType == itemType)
                {
                    System.Console.WriteLine();
                    foreach (var item in productList)
                    {
                        if (item[3].TrimStart() == inputType)
                        {
                            System.Console.WriteLine("Name: " + item[0].TrimStart());
                        }
                    }
                }
            }
        }

        internal List<List<string>> AddNewPurchaseDetail()
        {
            System.Console.WriteLine("Name: ");
            var prdName = Console.ReadLine();

            System.Console.WriteLine("Quantity: ");
            var prdQty = int.Parse(Console.ReadLine());

            double amt = 0;
            foreach (var product in productList)
            {
                if (product[0].TrimStart() == prdName && product[2].TrimStart() != "0")
                {
                    amt = prdQty * Double.Parse(product[1]);
                    product[2] = (int.Parse(product[2]) - prdQty).ToString();
                    break;
                }
            }

            System.Console.WriteLine("Final Amount: " + amt);
            return productList;
        }

        public void DisplayAll(List<List<string>> dataList)
        {
            foreach (var item in dataList)
            {
                if (item[2].TrimStart() != "0")
                {
                    System.Console.WriteLine(item[0].ToString() + ", "
                    + item[1].ToString() + " RS, "
                    + item[2].ToString() + ", "
                    + item[3].ToString());
                }
            }
        }
    }
}