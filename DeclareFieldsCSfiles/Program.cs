

class Sample
{
    static void Main()
    {
        //creating reference
        Product product1, product2,product3;

        //create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();


        //initializefields

        product1.productId = 1001;
        product1.productName = "Purushotham";
        product1.cost = 20000;
        product1.quantityInStock = 100;

        product2.productId = 1002;
        product2.productName = "Raju";
        product2.cost = 15000;
        product2.quantityInStock = 10;

        product3.productId = 1003;
        product3.productName = "Ramesh";
        product3.cost = 2000;
        product3.quantityInStock = 200;

    }
}

