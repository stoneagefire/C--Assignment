using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Product();

            var prdList = new List<List<string>>();

            prdList.Add(obj.getData());

            obj.DisplayAll(prdList, (double)120.75);
            
        }
    }
}