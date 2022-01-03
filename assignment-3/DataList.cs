using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace assignment_3
{
    public class DataList
    {
        IDictionary<int, string> dict;
        

        public DataList(IDictionary<int, string> dict)
        {
            this.dict = dict;
        }

        public void DictAddition(int key, string value)
        {
            this.dict.Add(key, value);
        }

        public void AddNewDetail()
        {
            System.Console.WriteLine("Enter PM Name: ");
            var name = System.Console.ReadLine();

            System.Console.WriteLine("Enter year: ");
            var year = System.Console.ReadLine();

            DictAddition(int.Parse(year), name);
        }

        internal void FindPMByYear(int year)
        {
            int status = 0;
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                if (kvp.Key == year)
                {
                    System.Console.WriteLine("PM of year " + kvp.Key + " is " + kvp.Value);
                }
                else
                {
                    status+=1;
                }
            }
            if(status==dict.Count)
            {
                System.Console.WriteLine("No PM data found for input year...");
            }
        }

        public void Display()
        {
            if(dict.Count!=0)
            {
                var list = dict.Keys.ToList();
                list.Sort();
                foreach (var i in list)
                {
                    System.Console.WriteLine("Name: {0}\tYear: {1}", i, dict[i]);
                }
            }
            else
            {
                System.Console.WriteLine("No data to display");
            }
        }
    }
}