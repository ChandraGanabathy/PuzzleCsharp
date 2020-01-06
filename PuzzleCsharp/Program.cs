using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCsharp
{
    class SortedArrayOccurance
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
    public class Occurence
    {
        private char[] givenSortedArray;
        private Dictionary<char, int> dict;

        public Occurence(char[] letters)
        {
            givenSortedArray = letters;
            dict = new Dictionary<char, int>();
        }
        public void CountOccurenceOrderofN(int LeftIndex, int RightIndex)
        {
            for (int i = LeftIndex; i <= RightIndex; i++)
            {
                if (!dict.Keys.Contains(givenSortedArray[i]))
                    dict.Add(givenSortedArray[i], 1);
                else
                    dict[givenSortedArray[i]] += 1;
            }
        }
        public void CountOccurenceorderoflogN(int LeftIndex, int RightIndex)
        {
            var Diff = RightIndex - LeftIndex;
            if (givenSortedArray[LeftIndex] == givenSortedArray[RightIndex])
            {
                if (!dict.Keys.Contains(givenSortedArray[LeftIndex]))
                {
                    dict.Add(givenSortedArray[LeftIndex], Diff + 1);
                }
                else
                {
                    dict[givenSortedArray[LeftIndex]] += Diff + 1;
                }
            }
            else
            {
                var HalfDiff = Math.Abs(Diff / 2);
                CountOccurenceorderoflogN(LeftIndex, LeftIndex + HalfDiff);
                CountOccurenceorderoflogN(LeftIndex + HalfDiff + 1, RightIndex);
            }
        }

        public void DisplayAnswer()
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.ToString() + "-" + item.Value);
            }
        }
    }
}