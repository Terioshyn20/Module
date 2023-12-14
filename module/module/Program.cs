using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Введіть числа через кому:");
        string input = Console.ReadLine();

        List<int> numbers = input.Split(',').Select(int.Parse).ToList();

        List<int> result = AddTenToEachNumber(numbers);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", result));
    }

    static List<int> AddTenToEachNumber(List<int> inputNumbers)
    {
        return inputNumbers.Select(x => x + 10).ToList();
    }
}
