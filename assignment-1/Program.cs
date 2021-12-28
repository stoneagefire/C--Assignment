using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            bool flag = true;
            int count = 0;
            string[] EmpDataList = new string[100];
            var tempCount = 0;

            while (flag)
            {
                System.Console.WriteLine("\nEmployee Interface");
                System.Console.WriteLine("----------------------------------------------------------------");
                System.Console.WriteLine("1. Enter new employee detail.");
                System.Console.WriteLine("2. Edit employee detail");
                System.Console.WriteLine("3. Display all employee");
                System.Console.WriteLine("4. Exit");
                System.Console.WriteLine("----------------------------------------------------------------");

                System.Console.WriteLine("Enter choice :");
                int ch = int.Parse(System.Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        //Enter emp data
                        string[] tempOneEmpData = employee.GetNewEmployeeData();
                        foreach (string ele in tempOneEmpData)
                        {
                            EmpDataList[count] = ele;
                            count++;
                        }
                        break;

                    case 2:
                        //Edit empdata
                        tempCount = 0;
                        System.Console.WriteLine("\n\nEmployee List");
                        System.Console.WriteLine("----------------------------------------------------------------");
                        for (var i = 0; i < count / 3; i++)
                        {
                            employee.Display(EmpDataList[tempCount], EmpDataList[tempCount + 1], EmpDataList[tempCount + 2]);
                            tempCount += 3;
                        }
                        System.Console.WriteLine("\n----------------------------------------------------------------");

                        string[] tempEditEmpList = employee.EditEmployeeDetail(EmpDataList);
                        tempCount = 0;
                        foreach (var ele in tempEditEmpList)
                        {
                            EmpDataList[tempCount] = ele;
                            tempCount++;
                        }
                        break;

                    case 3:
                        //Display emp data
                        tempCount = 0;
                        System.Console.WriteLine("\nEmployee List");
                        for (var i = 0; i < count / 3; i++)
                        {
                            employee.Display(EmpDataList[tempCount], EmpDataList[tempCount + 1], EmpDataList[tempCount + 2]);
                            tempCount += 3;
                        }
                        break;

                    case 4:
                        System.Console.WriteLine("Thank you ");
                        flag = false;
                        break;

                    default:
                        System.Console.WriteLine("Invalid Input");
                        continue;
                }
            }
        }
    }
}
