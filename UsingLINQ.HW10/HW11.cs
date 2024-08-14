using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UsingLINQ.HW10
{
    public class UsingLING
    {
        public void PrintSomething(List<object> data)
        {
            Console.WriteLine(string.Join(", ", data.Where(x => !(x is ArtObject))));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Film>().SelectMany(f => f.Actors).Select(a => a.Name)));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Film>().SelectMany(f => f.Actors).Count(a => a.Birthdate.Month == 8)));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Film>().SelectMany(f => f.Actors).OrderBy(a => a.Birthdate).Take(2).Select(a => a.Name)));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Book>().GroupBy(b => b.Author).Select(g => $"{g.Key}: {g.Count()}")));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<ArtObject>().GroupBy(a => a.Author).Select(g => $"{g.Key}: {g.Count()}")));

            Console.WriteLine("\n" + data.OfType<Film>().SelectMany(f => f.Actors).SelectMany(a => a.Name).Distinct().Count(char.IsLetter));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Book>().OrderBy(b => b.Author).ThenBy(b => b.Pages).Select(b => b.Name)));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Film>().SelectMany(f => f.Actors.Select(a => $"{a.Name}: {f.Name}"))));

            Console.WriteLine("\n" + data.OfType<Book>().Sum(b => b.Pages) + data.OfType<IEnumerable<int>>().SelectMany(i => i).Sum());

            data.OfType<Book>().GroupBy(b => b.Author).ToDictionary(g => g.Key, g => g.Select(b => b.Name).ToList()).ToList().ForEach(kv => Console.WriteLine($"{kv.Key}: {string.Join(", ", kv.Value)}"));

            Console.WriteLine("\n" + string.Join(", ", data.OfType<Film>().Where(f => f.Actors.Any(a => a.Name == "Matt Damon") && !f.Actors.Any(a => data.Contains(a.Name))).Select(f => f.Name)));
        }
    }
}
