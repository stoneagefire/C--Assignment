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

        public void DisplayAll(List<List<string>> dataList, double amt)
        {
            foreach (var item in dataList)
            {
                var sam = item.ToArray();
                System.Console.WriteLine(sam[0].ToString() + ", " + sam[1].ToString() + ", " + sam[2].ToString() + ", " + sam[3].ToString());
            }
        }
    }
}