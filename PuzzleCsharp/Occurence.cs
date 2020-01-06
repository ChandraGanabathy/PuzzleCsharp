using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCsharp
{
    public class Occurence
    {
        private char[] givenSortedArray;
        public Dictionary<char, int> dict;

        public Occurence(char[] letters)
        {
            givenSortedArray = letters;
            dict = new Dictionary<char, int>();
        }
        //Regardless of the duplicates, this function always go through each and every item in the array.
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
        //This method uses the recursion to find the occurence, it uses exponential form of 2.
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
