using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment_2
{
    class ProductList
    {
        public int totalItems = 0;
        public string rawData = "lettuce, 10.5, 50, Leafy green\n"
            + "cabbage, 20, 100, Cruciferous\n"
            + "pumpkin, 30, 30, Marrow\n"
            + "cauliflower, 10, 25, Cruciferous\n"
            + "zucchini, 20.5, 50, Marrow\n"
            + "yam, 30, 50, Root\n"
            + "spinach, 10, 100, Leafy green\n"
            + "broccoli, 20.2, 75, Cruciferous\n"
            + "garlic, 30, 20, Leafy green\n"
            + "silverbeet, 10, 50, Marrow";

        public List<List<string>> rawDataList;

        public List<List<string>> dataSplit()
        {
            
            var data = rawData.Split("\n");
            rawDataList = new List<List<string>>();
            foreach(var ele in data)
            {
                var tempList = new List<string>();
                string[] newData = ele.Split(", ");
                for (var i=0; i<newData.Length; i++)
                {
                    tempList.Add(newData[i]);

                }
                totalItems = totalItems + int.Parse(newData[2]);
                rawDataList.Add(tempList);
            }
            return rawDataList;
        }
    }
}