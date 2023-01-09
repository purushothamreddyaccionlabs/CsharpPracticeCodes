

class Sample
{
    static void Main()
    {
        //creating reference
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.noOfProducts++;
        product2 = new Product();
        Product.noOfProducts++;
        product3 = new Product();
        Product.noOfProducts++;


        //initializefields

        product1.productId = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantity = 100;

        product2.productId = 1002;
        product2.productName = "Cycle";
        product2.cost = 15000;
        product2.quantity = 10;

        product3.productId = 1003;
        product3.productName = "TV";
        product3.cost = 20002;
        product3.quantity = 200;
        

        //call Methods

        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();


        // print the objects
        Console.WriteLine("Product1 Details");
        Console.WriteLine("ProductId: " + product1.productId);
        Console.WriteLine("ProductName: " + product1.productName);
        Console.WriteLine("ProductCost: " + product1.cost);
        Console.WriteLine("tax: " + product1.tax);
        Console.WriteLine("ProductQuantity: " + product1.quantity);
        Console.WriteLine(Product.noOfProducts);


        Console.WriteLine("\nProduct2 Details");
        Console.WriteLine("ProductId: " + product2.productId);
        Console.WriteLine("ProductName: " + product2.productName);
        Console.WriteLine("ProductCost: " + product2.cost);
        Console.WriteLine("tax: " + product2.tax);
        Console.WriteLine("ProductQuantity: " + product2.quantity);
        Console.WriteLine(Product.noOfProducts);


        Console.WriteLine("\nProduct3 Details");
        Console.WriteLine("ProductId: " + product3.productId);
        Console.WriteLine("ProductName: " + product3.productName);
        Console.WriteLine("ProductCost: " + product3.cost);
        Console.WriteLine("tax: " + product3.tax);
        Console.WriteLine("ProductQuantity: " + product3.quantity);
        Console.WriteLine(Product.noOfProducts);
        int totalQuantity = product1.quantity + product2.quantity + product3.quantity;
        Console.WriteLine(totalQuantity);

        
        if (product1.cost > product2.cost && product1.cost > product3.cost)
        {
            Console.WriteLine("HeightestCost is product1 cost: " + product1.cost);
        }
        if(product2.cost > product1.cost && product2.cost > product3.cost)
        {
            Console.WriteLine("HeighestCost is product2 cost: " + product2.cost);
        }
        if(product3.cost > product1.cost && product3.cost > product2.cost)
        {
            Console.WriteLine("HeighestCost is product3 cost:{0} ", product3.cost);
        }
        System.Console.ReadKey();
    }
    
}
