using System;
class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            Id = 101,
            Name = "Ramu",
            Salary = 3909
        };
        Customer customer2 = new Customer()
        {
            Id = 129,
            Name = "Praveen",
            Salary = 5643
        };
        Customer customer3 = new Customer()
        {
            Id = 123,
            Name = "Hari",
            Salary = 9876
        };

       

        List<Customer> list = new List<Customer>(2);
        list.Add(customer1);
        list.Add(customer2);
        list.Add(customer3);
        /*    list.Insert(0, customer3);*/

        /*    foreach(Customer c in list)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2}",c.Id, c.Name, c.Salary);
            }*/
        //Console.WriteLine(list.IndexOf(customer3,(list.Count-1)));
        //Console.WriteLine(list.IndexOf(customer3, 1));
        //Console.WriteLine(list.IndexOf(customer3, 1,2));

        /*  if (list.Contains(customer3))
          {
              Console.WriteLine("Customer3 exists in the list");
          }
          else
          {
              Console.WriteLine("Customer3 does not exists in the list");
          }
         if(list.Exists(cust => cust.Name.StartsWith("p")))
          {
              Console.WriteLine("true");
          }
          else
          {
              Console.WriteLine("false");
          }*/
        // FindLast
        /*   Customer c = list.FindLast(cust => cust.Salary > 5000);
           Console.WriteLine("Id = {0} Name = {1} Salary = {2}",c.Id,c.Name,c.Salary);*/

        /*        List<Customer> customeslist = list.FindAll(cust => cust.Salary > 5000);
                foreach(Customer item in customeslist)
                {
                    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", item.Id, item.Name, item.Salary);
                }*/

        /*  int index = list.FindLastIndex(cost => cost.Salary > 8000);
          Console.WriteLine(index);*/


        //Convert an array to a list
        Customer[] customerArray = new Customer[3];
        customerArray[0] = customer1;
        customerArray[1] = customer2;
        customerArray[2] = customer3;

        List<Customer> listCustomer = customerArray.ToList();

        foreach (Customer item in listCustomer)
        {
            Console.WriteLine("Id = {0} Name = {1} Salary = {2}", item.Id, item.Name, item.Salary);
        }

        Customer[] arrayList = list.ToArray();
        Console.WriteLine(arrayList);






    }
}
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
