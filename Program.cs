using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee BobAugust = new Employee ("Bob August", "Marketing Director", DateTime.Now);
            Employee MaryPatrick = new Employee ("Mary Patrick", "Vice President", DateTime.Now);
            Employee ThomasPickett = new Employee ("Thomas Pickett", "Tech Support", DateTime.Now);
            Company AcmeBananas = new Company ("Acme Bananas", DateTime.Now);
            AcmeBananas.AddEmployee(BobAugust);
            AcmeBananas.AddEmployee(MaryPatrick);
            AcmeBananas.AddEmployee(ThomasPickett);
            AcmeBananas.RemoveEmployee(ThomasPickett);
            AcmeBananas.ListEmployees();
        }
    }

    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        public List<Employee> Employees = new List<Employee>();

        public void AddEmployee (Employee newemployee) 
        {
            Employees.Add(newemployee);
        }
        public void RemoveEmployee (Employee oldemployee)
        {
            Employees.Remove(oldemployee);
        }

        public void ListEmployees()
        {
            foreach (Employee e in Employees) {
                Console.WriteLine(e.Name);
            }
        }
        public Company (string name, DateTime createdon)
        {
            this.Name = name;
            this.CreatedOn = createdon;
        }
    }
    public class Employee
    {
        public string Name { get; set;}
        public string JobTitle { get; set;}
        public DateTime StartDate { get; set;}
        public Employee (string name, string jobtitle, DateTime startdate)
        {
            this.Name = name;
            this.JobTitle = jobtitle;
            this.StartDate = startdate;
        }
    }
}