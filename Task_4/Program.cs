using System;
using System.Linq;
class Program
{
    static int[] RemoveNegatives(int[] numbers)
    {
        int[] res = numbers.Where(x => x >= 0).ToArray();
        return res;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 5, -3, 9, -1, 2, -7, 0 }; // Пример массива
        int[] result = RemoveNegatives(numbers);
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}