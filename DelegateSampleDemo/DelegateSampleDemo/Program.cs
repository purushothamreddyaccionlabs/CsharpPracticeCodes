using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { Id = 101, Name = "Rahul",Salaray=5000,Experience=5});
        empList.Add(new Employee() { Id = 102, Name = "Arun", Salaray = 6000, Experience = 6 });
        empList.Add(new Employee() { Id = 103, Name = "Hema", Salaray = 7000, Experience = 5 });
        empList.Add(new Employee() { Id = 104, Name = "Latha", Salaray = 3000, Experience = 3 });
        empList.Add(new Employee() { Id = 105, Name = "Randeep", Salaray = 9000, Experience = 9 });

        Employee.PromotedEmployee(empList);
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salaray { get; set; }
    public int Experience { get; set; }

    public static void PromotedEmployee(List<Employee> employeesList)
    {
        foreach(Employee employee in employeesList)
        {
            if(employee.Experience >= 5) 
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }

}
