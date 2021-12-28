using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment_1
{
    public delegate void Notify(object sender, EventArgs args);
    public class Employee
    {
        public int Id;
        public string Name;
        public string DepartmentName;
        // private string methodActive;
        public event Notify notify;
        private static string activeMethod = "";

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
            activeMethod = "GetId() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

            System.Console.WriteLine("\nEnter employee id : ");
            string tempEmpId = System.Console.ReadLine();
            return tempEmpId;
        }

        public string GetName()
        {
            activeMethod = "GetName() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

            System.Console.WriteLine("\nEnter employee name : ");
            var tempEmpName = System.Console.ReadLine();
            return tempEmpName;
        }

        public string GetDepartmentName()
        {
            activeMethod = "GetDepartmentName() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

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
            activeMethod = "GetNewEmployeeData() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

            string[] tempData = { GetId(), GetName(), GetDepartmentName() };
            return tempData;
        }

        public string[] EditEmployeeDetail(string[] dataList)
        {
            activeMethod = "EditEmployeeDetail() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

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
            activeMethod = "Display() method is called";
            ActiveMethod(this, new EventArgs());
            notify += ActiveMethod;

            System.Console.Write($"\nID: {id}  NAME: {name}  DEPT: {dept}");
        }

        public static void ActiveMethod(object sender, EventArgs e)
        {
            System.Console.WriteLine(activeMethod);
        }
    }
}