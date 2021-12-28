using System;
using System.Collections.Generic;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            DataList obj = new DataList(dict);

            bool flag = true;

            while(flag)
            {
                System.Console.WriteLine("\n===========================================");
                System.Console.WriteLine("1. Add new PM details");
                System.Console.WriteLine("2. Find PM by year");
                System.Console.WriteLine("3. List PM by year");
                System.Console.WriteLine("4. Exit");
                System.Console.WriteLine("===========================================");
                System.Console.WriteLine("Enter choice : ");
                var choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.AddNewDetail();
                        break;

                    case 2:
                        System.Console.WriteLine("Enter year : ");
                        var year = Console.ReadLine();
                        obj.FindPMByYear(int.Parse(year));
                        break;

                    case 3:
                        obj.Display();
                        break;

                    case 4:
                        flag = false;
                        break;

                    default:
                        System.Console.WriteLine("Invalid choice!");
                        continue;
                }
            }
        }
    }
}
