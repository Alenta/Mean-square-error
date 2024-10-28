using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Mean_square_error;

class Program
{
    
    static void Main(string[] args)
    {

        //   https://www.codewars.com/kata/5254ca2719453dcc0b00027d/train/csharp
        List<String> str = [];
        //Console.WriteLine(Solution(new int[] {1, 2, 3}, new int[] {4, 5, 6}));
        //Console.WriteLine(GetReadableTime(20000));
        //Console.WriteLine(Alphanumeric("æ_"));
        str = SinglePermutations("abc");
        foreach (var item in str)
        {
            Console.WriteLine(item);
        }
        
        
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

    public static string GetReadableTime(int seconds)
    {
        double h = 0;
        double min = 0;
        double sec = 0;
        while (seconds!=0){
            if(seconds >= 3600){
                seconds -= 3600;
                h += 1;
            }
            else if(seconds > 60){
                seconds -= 60;
                min+=1;
            }
            else {sec = seconds; seconds-=seconds;}
        }
        Console.WriteLine(String.Format("{0:00}", h));
        return String.Format("{0:00}", h)+":"+String.Format("{0:00}", min)+":"+String.Format("{0:00}", sec);
    }

    public static bool Alphanumeric(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsLetter(str[i]) && !char.IsNumber(str[i])) return false;
        }
        return true;
    }

    public static bool Numeric(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsLetter(str[i]) && !char.IsNumber(str[i])) return false;
        }
        return true;
    }


    public static List<string> SinglePermutations(string s)
    {
        return null;
    }

    public static string Rot13(string message)
    {
        // your code here
        //message = message << 1;
        return "";
    }

}
