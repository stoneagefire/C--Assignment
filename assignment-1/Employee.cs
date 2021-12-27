using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment_1
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string DepartmentName;

        public Employee()
        {

        }
        public Employee(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }

        public string GetId()
        {
            System.Console.WriteLine("\nEnter employee id : ");
            string tempEmpId = System.Console.ReadLine();
            return tempEmpId;
        }

        public string GetName()
        {
            System.Console.WriteLine("\nEnter employee name : ");
            var tempEmpName = System.Console.ReadLine();
            return tempEmpName;
        }

        public string GetDepartmentName()
        {
            System.Console.WriteLine("\nEnter employee Department-Name : ");
            var tempEmpDeptName = System.Console.ReadLine();
            return tempEmpDeptName;
        }

        public void UpdateData(int Id)
        {
            this.Id = Id;
        }

        public void UpdateData(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void UpdateData(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }

        public string[] GetNewEmployeeData()
        {
            string[] tempData = { GetId(), GetName(), GetDepartmentName() };
            return tempData;
        }

        public string[] EditEmployeeDetail(string[] dataList)
        {

            System.Console.Write("\nEnter empID : ");
            var tempid = System.Console.ReadLine();

            for (var i = 0; i < dataList.Length; i++)
            {
                if (dataList[i] == tempid)
                {
                    dataList[i + 1] = GetName();
                    dataList[i + 2] = GetDepartmentName();

                    System.Console.WriteLine("Data updated");
                    break;
                }
                i += 3;
            }
            return dataList;
        }

        public void Display(string id, string name, string dept)
        {
            System.Console.Write($"\nID: {id}  NAME: {name}  DEPT: {dept}");
        }
    }
}