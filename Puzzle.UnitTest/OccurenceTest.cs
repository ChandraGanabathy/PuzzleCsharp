using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PuzzleCsharp.UnitTest
{
    [TestClass]
    public class OccurenceTest
    {
        [TestMethod]
        public void AreEqualtotheInputkeyvalue()
        {
            char[] input = "aaabbcdffffffffffffhhhhhhhh".ToCharArray();
            Occurence _occurence = new Occurence(input);
            _occurence.CountOccurenceorderoflogN(0, input.Length - 1);
            Assert.AreEqual(_occurence.dict['f'], 12);
        }
        public void AreEqualtotheInputkeyvalueorderofN()
        {
            char[] input = "aaabbcdffffffffffffhhhhhhhh".ToCharArray();
            Occurence _occurence = new Occurence(input);
            _occurence.CountOccurenceOrderofN(0, input.Length - 1);
            Assert.AreEqual(_occurence.dict['f'], 12);
        }
        public void AreEqualtotheInputkeyvalue_large()
        {
            char[] input = "aaabbcdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy".ToCharArray();
            Occurence _occurence = new Occurence(input);
            _occurence.CountOccurenceorderoflogN(0, input.Length - 1);
            Assert.AreEqual(_occurence.dict['a'], 3);
        }
        public void AreEqualtotheInputkeyvalueorderofN_large()
        {
            char[] input = "aaabbcdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz".ToCharArray();
            Occurence _occurence = new Occurence(input);
            _occurence.CountOccurenceOrderofN(0, input.Length - 1);
            Assert.AreEqual(_occurence.dict['a'], 3);
        }
    }
}
