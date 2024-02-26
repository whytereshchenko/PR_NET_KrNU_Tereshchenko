using System.Text;
using static System.Console;

namespace lab1;

internal class Problem2
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        OutputEncoding = Encoding.UTF8;
        
        WriteLine("Введіть a: ");
        double a = Convert.ToDouble(ReadLine());
        WriteLine("Введіть b: ");
        double b = Convert.ToDouble(ReadLine());
        WriteLine("Введіть c: ");
        double c = Convert.ToDouble(ReadLine());
        WriteLine("Введіть d: ");
        double d = Convert.ToDouble(ReadLine());
        
        if (c >= d)
        {
            WriteLine("Інтервал (c, d) не валідний, оскільки c >= d !");
            return;
        }
        
        if (a >= 1 && a <= 2 && a > c && a < d)
        {
            WriteLine($"Число {a} належить перетину інтервалів [1:2] і (c, d).");
        }
        else
        {
            WriteLine($"Число {a} не належить перетину інтервалів [1:2] і (c, d).");
        }
        
        if (b >= 1 && b <= 2 && b > c && b < d)
        {
            WriteLine($"Число {b} належить перетину інтервалів [1:2] і (c, d).");
        }
        else
        {
            WriteLine($"Число {b} не належить перетину інтервалів [1:2] і (c, d).");
        }
    }
    
}