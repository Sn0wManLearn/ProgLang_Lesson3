using System;
using System.Linq;
class Program
{
    static void SwapSigns(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = -numbers[i];
        }        
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, -5, 6, -7, 3, 7, -2, 8, 10, -9 }; // Пример массива
        SwapSigns(numbers);
        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }
}
