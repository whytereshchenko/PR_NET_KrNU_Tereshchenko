namespace lab2;

public class Problem1
{
    static void Main()
    {
        int[] production = { 40, 35, 37, 45, 32, 38 };
        int minProduction = FindMinimumProduction(production);
        Console.WriteLine($"Найменший денний виробіток: {minProduction}");
    }

    static int FindMinimumProduction(int[] production)
    {
        int min = production[0];
        for (int i = 1; i < production.Length; i++)
        {
            if (production[i] < min)
            {
                min = production[i];
            }
        }
        return min;
    }
}