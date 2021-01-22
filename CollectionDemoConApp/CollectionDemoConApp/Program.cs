using System;
using System.Collections.Generic;

namespace CollectionDemoConApp
{


    public class Employee {
        private int _EmpId;
        private string _EmpName;

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.EmpName = name;
        }

        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }
       
    }
    







    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            Employee employee1 = new Employee() { EmpId = 1, EmpName = "Popy" };
            Employee employee2 = new Employee() { EmpId = 2, EmpName = "Lee" };
            Employee employee3 = new Employee() { EmpId = 3, EmpName = "Joe" };

            employees.Add(employee1.EmpId, employee1);
            employees.Add(employee2.EmpId, employee2);
            employees.Add(employee3.EmpId, employee3);

            foreach (KeyValuePair<int, Employee> employee in employees) {

                Console.WriteLine("EmpId = {0}, EmpName = {1}",
              employee.Value.EmpId, employee.Value.EmpName);

            }
        }
    }
}
