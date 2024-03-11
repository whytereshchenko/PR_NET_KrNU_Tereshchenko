namespace lab3;

public class City
{
    private static int totalCities = 0;
    private static int totalPopulation = 0;

    public string Name { get; set; }
    public string Country { get; set; }
    public int Population { get; set; }
    public string PostalCode { get; set; }
    public string[] Districts { get; set; }

    public City(string name, string country, int population, string postalCode, string[] districts)
    {
        Name = name;
        Country = country;
        Population = population;
        PostalCode = postalCode;
        Districts = districts;
        totalCities++;
        totalPopulation += population;
    }

    public static int GetTotalCities()
    {
        return totalCities;
    }

    public static int GetTotalPopulation()
    {
        return totalPopulation;
    }

    public void DisplayCityInfo()
    {
        Console.WriteLine($"Name: {Name}, Country: {Country}, Population: {Population}, Postal Code: {PostalCode}, Districts: {String.Join(", ", Districts)}");
    }
    
}

class Problem2
{
    static void Main()
    { 
        City city = new City("Kyiv", "Ukraine", 2800000, "02000", new string[] { "Shevchenkivskyi", "Darnytskyi" });
        city.DisplayCityInfo();
        Console.WriteLine($"Total Cities: {City.GetTotalCities()}, Total Population: {City.GetTotalPopulation()}");
    }
}