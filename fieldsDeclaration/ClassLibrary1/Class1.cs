public class Product
{
    //fields

    public int productId;
    public string productName;
    public double cost;
    public double tax;
    public int quantity;
    public static int noOfProducts;

    //Method
    /* cost <= 20000 then tax = 10%
        cost > 20000 then tax = 12%*/
    public void CalculateTax()
    {
        // create local variable

        double t;

        //calculate tax

        if (cost <= 20000)
        {
            t = cost * 10 / 1000;
        }
        else
        {
            t = cost * 12 / 1000;
        }
        tax = t;
    }
}

