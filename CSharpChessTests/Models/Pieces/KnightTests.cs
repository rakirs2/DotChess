using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Pieces;

namespace CSharpChess.Models.Pieces.Tests
{
    [TestClass()]
    public class KnightTests
    {
        [TestMethod()]
        public void KnightIdentityTest()
        {
            Knight black = new(Color.Black, new Position(0, 0));
            Knight white = new(Color.White, new Position(0, 0));
            Assert.AreEqual(black.GetPieceType(), PieceType.Knight);
            Assert.AreEqual(black.GetPieceType(), white.GetPieceType());
            Assert.AreEqual(black.GetColor(), Color.Black);
            Position position = new(0, 0);
            Assert.AreEqual(position, black.GetCurrentPosition());
        }

        [TestMethod()]
        public void GetPossibleMovesTestCenter()
        {
            Knight black = new(Color.Black, new Position(3, 3));
            HashSet<Position> possibleMoves = black.GetPossibleMoves();
            HashSet<Position> expectedMoves = new()
            {
                new Position(5, 4),
                new Position(4, 5),
                new Position(2, 5),
                new Position(1, 4),
                new Position(1, 2),
                new Position(4, 1),
                new Position(5, 2),
                new Position(4, 1)
            };
            Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
        }

        [TestMethod()]
        public void GetPossibleMovesTest3Options()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void GetPossibleMovesTestCorner()
        {
            Assert.Fail();
        }

    }
}