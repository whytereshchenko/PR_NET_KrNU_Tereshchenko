using System.Text;
using static System.Console;

namespace lab1
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            OutputEncoding = Encoding.UTF8;
            
            Write("Введіть першу сторону: ");
            double firstSide = Convert.ToDouble(ReadLine());
                
            Write("Введіть другу сторону: ");
            double secondSide = Convert.ToDouble(ReadLine());
            
            Write("Введіть третю сторону: ");
            double thirdSide = Convert.ToDouble(ReadLine());

            if (!(firstSide + secondSide > thirdSide) || 
                !(firstSide + thirdSide > secondSide) ||
                !(secondSide + thirdSide > firstSide))
            {
                Write("Трикутник з такими сторонами не існує!");
                return;
            }
            
            double p = (firstSide + secondSide + thirdSide) / 2;
            
            double area = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            
            WriteLine("Площа трикутника: " + area);
        }
    }
}

