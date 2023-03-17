using System;
class Program {

    static void Main() 
    {
        Country country1 = new Country() { Code = "IND", Name = "INDIA",Capital = "New Delhi"};
        Country country2 = new Country() { Code = "USA", Name = "UNITED STATES OF AMERICA", Capital = "Washington D.C." };
        Country country3 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };
        Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
        Country country5 = new Country() { Code = "UAE", Name = "UNITED ARAB EMIRATES", Capital = "Dubai" };



        List<Country> list = new List<Country>();
        list.Add(country1);
        list.Add(country2);
        list.Add(country3);
        list.Add(country4);
        list.Add(country5);

        Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
        dictionaryCountries.Add(country1.Code, country1);
        dictionaryCountries.Add(country2.Code, country2);
        dictionaryCountries.Add(country3.Code, country3);
        dictionaryCountries.Add(country4.Code, country4);
        dictionaryCountries.Add(country5.Code, country5);

        string userChoice = string.Empty;
        do
        {
            Console.WriteLine("Please enter country code");
            string userInput = Console.ReadLine().ToUpper();
            //Country resultCountry = list.Find(country => country.Code == userInput);

            Country resultCountry = dictionaryCountries.ContainsKey(userInput) ? dictionaryCountries[userInput] : null;
            if (resultCountry == null)
            {
                Console.WriteLine("Invalid country code");
            }
            else
            {
                Console.WriteLine("Name = {0} Capital = {1}", resultCountry.Name, resultCountry.Capital);
            }
            do
            {
                Console.WriteLine("Do you want to continue-YES or NO ?");
                userChoice = Console.ReadLine().ToUpper();
            } while (userChoice != "NO" && userChoice != "YES");

        } while (userChoice == "YES");
    }
}

public class Country
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }

}
