using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Pieces.Tests
{
    [TestClass()]
    public class KingTests
    {
        [TestMethod()]
        public void GetRankTest()
        {
            Random random = new Random();
            int randomRank = random.Next(0, 8);
            int randomFile = random.Next(0, 8);
            King king = new King(randomRank, randomFile);
            Assert.AreEqual(randomRank, king.GetRank());
            Assert.AreEqual(randomFile, king.GetFile());
        }

        // [TestMethod()]
        // public void GetPossibleMovesTest()
        // {
        //     King king = new King(4, 4);
        //     HashSet<int[]> expectedMoves = new HashSet<int[]>
        //     {
        //         new int[] { 5, 5 },
        //         new int[] { 5, 4 },
        //         new int[] { 5, 3 },
        //         new int[] { 4, 5 },
        //         new int[] { 4, 3 },
        //         new int[] { 3, 3 },
        //         new int[] { 3, 4 },
        //         new int[] { 3, 5 }
        //     };
        //     HashSet<int[]> actualMoves = king.GetPossibleMoves();
        //
        //     foreach (var position in expectedMoves)
        //     {
        //         Assert.IsTrue(actualMoves.Contains(position));
        //     }
        //     foreach(var position in actualMoves)
        //     {
        //         Assert.IsTrue(expectedMoves.Contains(position));
        //     }
        // }
    }
}