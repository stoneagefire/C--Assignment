using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

        // public TInput GetData<TInput>() where TInput : IConvertible
        // {
        //     var temp = (TInput) Console.ReadLine();
        //     return (TInput) temp;
        // }

        public List<string> getData()
        {
            var data = new List<string>();

            System.Console.WriteLine("Enter Product Name: ");
            data.Add(Console.ReadLine());

            System.Console.WriteLine("Enter Product Value: ");
            data.Add(Console.ReadLine()+" RS");

            System.Console.WriteLine("Enter Product Quantity: ");
            data.Add(Console.ReadLine());

            System.Console.WriteLine("Enter Product Type: ");
            data.Add(Console.ReadLine());

            return data;
        }

        public List<List<string>> AddNewProduct(List<List<string>> product)
        {
            System.Console.WriteLine("Enter no. of new products to add in inventry: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i<count; i++)
            {
                var tempData = getData();
                product.Add(tempData);
            }
            return product;
        }

        internal void FetchItemListByType(List<List<string>> productList)
        {
            string[] itemTypeList = {"Leafy green", "Cruciferous", "Marrow", "Root"};
            System.Console.WriteLine("available Item type :");
            foreach (string itemType in itemTypeList)
            {
                System.Console.Write(" "+itemType);
            }
            System.Console.WriteLine("Enter item type: ");
            string inputType = Console.ReadLine();

            System.Console.WriteLine(typeof());

            // foreach (string itemType in itemTypeList)
            // {
            //     if(itemType.ToString() == inputType.ToString())
            //     {
            //         foreach(var product in productList)
            //         {
            //             if(product[3]==inputType)
            //             {
            //                 System.Console.WriteLine("Name: " + product[0]);
            //             }
            //         }
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Invalid Item Type input");
            //         break;
            //     }
            // }
        }

        public void DisplayAll(List<List<string>> dataList)
        {
            foreach (var item in dataList)
            {
                var sam = item;
                System.Console.WriteLine(sam[0].ToString() + ", " 
                    + sam[1].ToString() + " RS, " 
                    + sam[2].ToString() + ", " 
                    + sam[3].ToString());
            }
        }
    }
}