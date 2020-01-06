using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = "aaabbcdffffffffffffhhhhhhhh".ToCharArray();
            var _occurence = new Occurence(input);

            Console.WriteLine("Printing O(n)");
            _occurence.CountOccurenceOrderofN(0, input.Length - 1);
            _occurence.DisplayAnswer();

            Console.WriteLine("====================================");
            var _occurencelog = new Occurence(input);
            _occurencelog.CountOccurenceorderoflogN(0, input.Length - 1);
            Console.WriteLine("Printing O(log n)");
            _occurence.DisplayAnswer();
            Console.ReadLine();
        }
    }
 
}