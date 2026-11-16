namespace MyLibrary
{
    public class OurClassLibrary
    {
        public static double MultiMatrix(double[,] matrix)
        {
            double sum = 0;
            double count = 0;
            double n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                Console.WriteLine();
            }
            double sr = sum / count;
            return sr;
        }
    }
}