using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;

namespace CSharpChessTests.Models.Pieces
{
    [TestClass()]
    public class BishopTests
    {
        [TestMethod()]
        public void BishopIdentityTest()
        {
            Bishop black = new(Color.Black, new Position(0, 0));
            Bishop white = new(Color.White, new Position(0, 0));
            Assert.AreEqual(PieceType.Bishop, black.GetPieceType());
            Assert.AreEqual(black.GetPieceType(), white.GetPieceType());
            Assert.AreEqual(black.GetColor(), Color.Black);
            Position position = new(0, 0);
            Assert.AreEqual(position, black.GetCurrentPosition());
        }


        [TestMethod()]
        public void GetPossibleMovesTestLowerLeft()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPossibleMovesLowerRight()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void GetPossibleMovesMiddle()
        {
            Assert.Fail();
        }
    }
}