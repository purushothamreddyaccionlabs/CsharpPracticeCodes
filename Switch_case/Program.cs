using System;
class program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;

    Start:
        Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid", userChoice);
                goto Start;
        }
    Decision:
        Console.WriteLine("Do you want to buy another coffee - YES or NO");
        string userDecision = Console.ReadLine();

        switch (userDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Please try again...", userDecision);
                goto Decision;
        }
        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill amount = ${0}", TotalCoffeeCost);
    }
}
