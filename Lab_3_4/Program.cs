//Высокий уровень, вариант 2
namespace FunctionTable
{
    class Program
    {
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static double CalculateF(double x)
        {
            double sum = 0;
            for (int k = 1; k <= 5; k++)
            {
                double numerator = Math.Pow(-2, k + 1) * Factorial(k + 1);
                double denominator = Math.Pow(x + 2.5, k + 1);
                sum += numerator / denominator;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double xn = -2;
            double xk = 3;
            double h = 0.5;
            for (double x = xn; x <= xk; x += h)
            {
                double fx = CalculateF(x);
                Console.WriteLine($"{x,11:F4} {fx,11:F4} ");
            }
        }
    }
}