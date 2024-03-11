namespace lab2;

public class Problem2
{
    static void Main()
    {
        double[,] matrix = {
            {1.5, 3.2, 4.7},
            {4.1, 2.5, 0.3},
            {3.3, 5.2, 1.8}
        };
            
        double[] maxElements = FindMaxInColumns(matrix);
        Console.WriteLine("Найбільші елементи у кожному стовпці:");
        for (int i = 0; i < maxElements.Length; i++)
        {
            Console.WriteLine($"Стовпець {i + 1}: {maxElements[i]}");
        }
    }

    static double[] FindMaxInColumns(double[,] matrix)
    {
        double[] maxElements = new double[matrix.GetLength(1)];
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            double max = matrix[0, col];
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] > max)
                {
                    max = matrix[row, col];
                }
            }
            maxElements[col] = max;
        }
        return maxElements;
    }
}