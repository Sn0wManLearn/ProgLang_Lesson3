using System;
using System.Linq;
class Program
{
    static double CalculateAverage(int[] numbers)
    {
        int sum = numbers.Sum();
        double res = (double) sum / numbers.Length;
        return res;
    }
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива
        double average = CalculateAverage(numbers);
        Console.WriteLine(average);
    }
}
