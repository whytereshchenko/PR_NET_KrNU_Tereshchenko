namespace lab3;

public class FuelReport
{
    public int Id { get; set; }
    public string BaseName { get; set; }
    public double FuelSpent { get; set; }
    public int VehiclesCount { get; set; }
    public double AverageFuelConsumption { get { return VehiclesCount != 0 ? FuelSpent / VehiclesCount : 0; } }

    public FuelReport(int id, string baseName, double fuelSpent, int vehiclesCount)
    {
        Id = id;
        BaseName = baseName;
        FuelSpent = fuelSpent;
        VehiclesCount = vehiclesCount;
    }
    
    public void DisplayReport()
    {
        Console.WriteLine($"Id: {Id}, Base: {BaseName}, Fuel Spent: {FuelSpent}, Vehicles: {VehiclesCount}, Avg Consumption: {AverageFuelConsumption}");
    }
    
}

class Problem1
{
    static void Main()
    {
        List<FuelReport> reports = new List<FuelReport>(); 
        reports.Add(new FuelReport(1, "A", 200, 50));
        reports.Add(new FuelReport(2, "B", 1500, 30));
        reports.Add(new FuelReport(3, "C", 1100, 20));
        reports.ForEach(report => report.DisplayReport()); 
    }
}