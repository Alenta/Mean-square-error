using System.Linq;

namespace Mean_square_error;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution(new int[] {1, 2, 3}, new int[] {4, 5, 6}));
    }

    public static double Solution(int[] firstArray, int[] secondArray)
    {
        // Two int arrays
        // Compare values, square the difference
        // Return average of the squared difference pairs
        List<double> remainders = new();
        for (int i = 0; i < firstArray.Length; i++)
        {
            double result = Math.Pow(Math.Abs(firstArray[i] - secondArray[i]),2);
            remainders.Add(result);
        }
        return Queryable.Average(remainders.AsQueryable());
    }
}
