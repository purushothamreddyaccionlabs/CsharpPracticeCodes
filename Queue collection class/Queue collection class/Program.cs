using System;

class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            Id = 101,
            Name = "Hari",
            Gender = "Male"
        };
        Customer customer2 = new Customer()
        {
            Id = 102,
            Name = "Mahesh",
            Gender = "Male"
        };
        Customer customer3 = new Customer()
        {
            Id = 104,
            Name = "Rani",
            Gender = "Female"
        };
        Customer customer4 = new Customer()
        {
            Id = 108,
            Name = "Kiran",
            Gender = "Male"
        };
        Customer customer5 = new Customer()
        {
            Id = 107,
            Name = "Ramya",
            Gender = "Female"
        };

        Queue<Customer> queuecustomer = new Queue<Customer>();
        
        //Adding items
        queuecustomer.Enqueue(customer1);
        queuecustomer.Enqueue(customer2);
        queuecustomer.Enqueue(customer3);
        queuecustomer.Enqueue(customer4);
        queuecustomer.Enqueue(customer5);

        //Retrieve items
        /*        Customer c1 =  queuecustomer.Dequeue();
                Console.WriteLine(c1.Id + " - " + c1.Name);
                Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);

                Customer c2 = queuecustomer.Dequeue();
                Console.WriteLine(c2.Id + " - " + c2.Name);
                Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);

                Customer c3 = queuecustomer.Dequeue();
                Console.WriteLine(c3.Id + " - " + c3.Name);
                Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);

                Customer c4 = queuecustomer.Dequeue();
                Console.WriteLine(c4.Id + " - " + c4.Name);
                Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);

                Customer c5 = queuecustomer.Dequeue();
                Console.WriteLine(c5.Id + " - " + c5.Name);
                Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);*/

        //this method returns an objects with out removing it
        Customer cp = queuecustomer.Peek();
        Console.WriteLine(cp.Id + " - " + cp.Name);
        Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);


        if (queuecustomer.Contains(customer4))
        {
            Console.WriteLine("Customer4 exits");
        }
        else
        {
            Console.WriteLine("Customer4 does not exits");
        }

        //With out removing
        /*        foreach (Customer c in queuecustomer)
                {
                    Console.WriteLine(c.Id + " - " + c.Name);
                    Console.WriteLine("Total items in the Queue = " + queuecustomer.Count);
                }*/



        //Stack collection Class
        Stack<Customer> stackCustomer = new Stack<Customer>();
        stackCustomer.Push(customer1);
        stackCustomer.Push(customer2);
        stackCustomer.Push(customer3);
        stackCustomer.Push(customer4);
        stackCustomer.Push(customer5);


        /* Customer sc1 = stackCustomer.Pop();
         Console.WriteLine(sc1.Id + " - " + sc1.Name);
         Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);

         Customer sc2 = stackCustomer.Pop();
         Console.WriteLine(sc2.Id + " - " + sc2.Name);
         Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);

         Customer sc3 = stackCustomer.Pop();
         Console.WriteLine(sc3.Id + " - " + sc3.Name);
         Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);

         Customer sc4 = stackCustomer.Pop();
         Console.WriteLine(sc4.Id + " - " + sc4.Name);
         Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);

         Customer sc5 = stackCustomer.Pop();
         Console.WriteLine(sc5.Id + " - " + sc5.Name);
         Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);*/
        /*
                foreach(Customer sc in stackCustomer)
                {
                    Console.WriteLine(sc.Id + " - " + sc.Name);
                    Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);
                }*/

        Customer sl = stackCustomer.Peek();
        Console.WriteLine(sl.Id + " - " + sl.Name);
        Console.WriteLine("Total items in the Queue = " + stackCustomer.Count);



    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}