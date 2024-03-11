namespace lab2;

class MatrixOperations
{
    public static double[,] MultiplyMatrixByNumber(double[,] matrix, double number)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * number;
            }
        }

        return result;
    }
    
    public static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
    
    public static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] result = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}


class Test
{
    static void Main()
    {
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        
        Console.WriteLine("\nПерша матриця:");
        PrintMatrix(matrix1);
        Console.WriteLine("\nДруга матриця:");
        PrintMatrix(matrix2);
        
        Console.WriteLine("\nМноження матриці на число:");
        var multipliedByNumber = MatrixOperations.MultiplyMatrixByNumber(matrix1, 2);
        PrintMatrix(multipliedByNumber);
        
        Console.WriteLine("\nДодавання матриць:");
        var sum = MatrixOperations.AddMatrices(matrix1, matrix2);
        PrintMatrix(sum);
        
        Console.WriteLine("\nДобуток матриць:");
        var product = MatrixOperations.MultiplyMatrices(matrix1, matrix2);
        PrintMatrix(product);
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}