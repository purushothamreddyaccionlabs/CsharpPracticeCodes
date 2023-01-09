
using System.Net.Http.Headers;
using System.Reflection;

class Encapsulation
{
    static void Main()
    {
        // create references to Product

        Product product1, product2, product3;


        // creating objects
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;


        // insert data 
        product1.SetProductId(1001);
        product1.SetProductName("Telivision");
        product1.SetProductPrice(43000);
        product1.SetProductQuantity(200);

        product2.SetProductId(1002);
        product2.SetProductName("Laptop");
        product2.SetProductPrice(97000);
        product2.SetProductQuantity(290);

        product3.SetProductId(1003);
        product3.SetProductName("Iphone12");
        product3.SetProductPrice(65000);
        product3.SetProductQuantity(760);



        //call calculationTax method
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();


        //Print the data 
        Console.WriteLine("Product1");
        Console.WriteLine("Id is: " + product1.GetProductId());
        Console.WriteLine("Name is: " + product1.GetProductName());
        Console.WriteLine("Price is: " + product1.GetProductPrice());
        Console.WriteLine("Tax is: " + product1.GetProductTax());
        Console.WriteLine("Quantity is: " + product1.GetProductQuantity());
        Console.WriteLine("Date of purchase: " + product1.GetDateOfPurchase());

        Console.WriteLine("\nProduct2");
        Console.WriteLine("Id is: " + product2.GetProductId());
        Console.WriteLine("Name is: " + product2.GetProductName());
        Console.WriteLine("Price is: " + product2.GetProductPrice());
        Console.WriteLine("Tax is: " + product2.GetProductTax());
        Console.WriteLine("Quantity is: " + product2.GetProductQuantity());
        Console.WriteLine("Date of purchase: " + product2.GetDateOfPurchase());


        Console.WriteLine("\nProduct3");
        Console.WriteLine("Id is: " + product3.GetProductId());
        Console.WriteLine("Name is: " + product3.GetProductName());
        Console.WriteLine("Price is: " + product3.GetProductPrice());
        Console.WriteLine("Tax is: " + product3.GetProductTax());
        Console.WriteLine("Quantity is: " + product3.GetProductQuantity());
        Console.WriteLine("Date of purchase: " + product3.GetDateOfPurchase());


        int totalQuantity = product1.GetProductQuantity() + product2.GetProductQuantity() + product3.GetProductQuantity();
        Console.WriteLine("\nTotal Quantity is: " + totalQuantity);
        Console.WriteLine("Total no of products is: " + Product.TotalNoProducts);
        Console.WriteLine("Category of products: " + Product.categoryType);
    }
}