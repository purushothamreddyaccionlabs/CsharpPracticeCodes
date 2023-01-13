class program
{
    public static void Main()
    {

        //string name, int age,string lastName, string gender,
        //string address,string degree,string degignation
        Doctor obj = new Doctor("Raghu",45,"babu","Male","12-23,Hyderabad","MBBS","Doctor");


        Console.WriteLine("Name: "+ obj.fullname());
        Console.WriteLine("age: " + obj.age);
        Console.WriteLine("gender: " + obj.gender);
        Console.WriteLine("address: " + obj.address);
        Console.WriteLine("degree: " + obj.degree);
        Console.WriteLine("degignation: " + obj.degignation);
       

    }
}