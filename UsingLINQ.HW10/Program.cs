using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", Enumerable.Range(10, 41)));

        Console.WriteLine("\n " + string.Join(", ", Enumerable.Range(10, 41).Where (n => n % 3 == 00)));

        Console.WriteLine("\n " + string.Join(", ", Enumerable.Repeat("Linq", 10)));

        Console.WriteLine("\n " + string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(s => s.Contains('a'))));

        Console.WriteLine("\n " + string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(s => s.Contains('a')).Select(s => s.Count(c => c == 'a'))));

        Console.WriteLine("\n " + string.Join(", ", "aaa;xabbx;abb;ccc;dap".Split(';').Any(m => m == "abb")));

        Console.WriteLine("\n " + string.Join(", ", "aaa;xabbx;abb;ccc;dap".Split(';').Where(word => word.Length == "aaa;xabbx;abb;ccc;dap".Split(';').Max(w => w.Length))));

        Console.WriteLine("\n " + "aaa;xabbx;abb;ccc;dap".Split(';').Average(word => word.Length));

        Console.WriteLine("\n " + new string("aaa;xabbx;abb;ccc;dap;zh".Split(';').OrderBy(word => word.Length).First().Reverse().ToArray()));

        Console.WriteLine("\n " + "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').First(word => word.StartsWith("aa")).Skip(2).All(c => c == 'b'));

        Console.WriteLine("\n " + "aaa;xabbx;abb;ccc;dap;zh".Split(';').Where(word => !word.EndsWith("bb")).Skip(2).Last());
    }
}
