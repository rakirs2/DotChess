using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;

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
            Assert.AreEqual(randomRank, king.GetPosition().Rank);
            Assert.AreEqual(randomFile, king.GetPosition().File);
        }

        //TODO.Srikar add a position object/overload hashcode/equals
        //what is wrong with this? --> hashset uses hashcode; for arrays it is just the pointer.
        [TestMethod()]
        public void GetPossibleMovesTest()
        {
            King king = new King(4, 4);
            HashSet<Position> expectedMoves = new HashSet<Position>
            {
                new Position( 5, 5 ),
                new Position( 5, 4 ),
                new Position( 5, 3 ),
                new Position( 4, 5 ),
                new Position( 4, 3 ),
                new Position( 3, 5 ),
                new Position( 3, 4 ),
                new Position( 3, 3 )
            };
            HashSet<Position> actualMoves = king.GetPossibleMoves();
        
            foreach (var position in expectedMoves)
            {
                Assert.IsTrue(actualMoves.Contains(position));
            }
            foreach(var position in actualMoves)
            {
                Assert.IsTrue(expectedMoves.Contains(position));
            }
        }
    }
}