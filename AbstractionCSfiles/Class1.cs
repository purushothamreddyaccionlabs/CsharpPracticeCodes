using System.Xml.Schema;

public class Product
{
    // field declaration
    private int productId;
    private string productName;
    private double price;
    private double tax;
    private int quantity;
    public static int TotalNoProducts;
    public const string categoryType = "Electronics";
    public readonly string dataOfPurchase;

    // constructor

    public Product()
    {
        dataOfPurchase = System.DateTime.Now.ToShortDateString();
    }



    // setProductid
    public void SetProductId(int value)
    {
        productId = value;
    }
    // Get productid
    public int GetProductId()
    {
        return productId;
    }
    //Set method for Product name
    public void SetProductName(string value)
    {
        productName = value;
    }
    //Get method for productName
    public string GetProductName()
    {
        return productName;
    }
    // Set method for price
    public void SetProductPrice(double value)
    {
        price = value;
    }
    //Get method for price
    public double GetProductPrice()
    {
        return price;
    }
    // Set ProductTax
    public void SetProductTax(double value)
    {
        tax = value;
    }
    // Get Product Tax
    public double GetProductTax()
    {
        return tax;
    }

    /* cost <= 20000 then 10%
       cost > 20000 then 12% */

    public void CalculateTax()
    {
        // declaring local variable
        double t;
        if (price <= 20000)
        {
            t = price * 10 / 1000;

        }
        else
        {
            t = price * 12 / 1000;
        }

        tax = t;
    }

    // Set Product quantity

    public void SetProductQuantity(int value)
    {
        quantity = value;
    }

    // Get Product quantity
    public int GetProductQuantity()
    {
        return quantity;
    }

    // Get method for date of purchase

    public string GetDateOfPurchase()
    {
        return dataOfPurchase;
    }













}

