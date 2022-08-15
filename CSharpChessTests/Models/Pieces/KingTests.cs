using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;
using CSharpChess.Models.Pieces;

namespace CSharpChess.Pieces.Tests
{
    [TestClass()]
    public class KingTests
    {
        [TestMethod()]
        public void KingTest()
        {
            King Black = new(Color.Black);
            King White = new(Color.White);
            Assert.AreEqual(Black.PieceType, PieceType.King);
            Assert.AreEqual(Black.PieceType, White.PieceType);
            Assert.AreEqual(Black.Color, Color.Black);

        }

        //[TestMethod()]
        //public void GetPossibleMovesTest()
        //{
        //    King king = new King(4, 4, Color.White);
        //    HashSet<Position> expectedMoves = new HashSet<Position>
        //    {
        //        new ( 5, 5 ),
        //        new ( 5, 4 ),
        //        new ( 5, 3 ),
        //        new ( 4, 5 ),
        //        new ( 4, 3 ),
        //        new ( 3, 5 ),
        //        new ( 3, 4 ),
        //        new ( 3, 3 )
        //    };
        //    HashSet<Position> actualMoves = king.GetPossibleMoves();
        //    //TODO.Srikar there has to be a better way
        //    foreach (Position move in actualMoves)
        //    {
        //        expectedMoves.Remove(move);
        //    }

        //    Assert.IsTrue(expectedMoves.Count == 0);
        //}
        //[TestMethod()]
        //public void GetPossibleMovesCornerTest()
        //{
        //    King king = new King(0, 0);
        //    HashSet<Position> expectedMoves = new HashSet<Position>
        //    {
        //        new ( 1, 0 ),
        //        new ( 0, 1 ),
        //        new ( 1, 1 )
        //    };
        //    HashSet<Position> actualMoves = king.GetPossibleMoves();
        //    //TODO.Srikar there has to be a better way
        //    foreach (Position move in actualMoves)
        //    {
        //        expectedMoves.Remove(move);
        //    }

        //    Assert.IsTrue(expectedMoves.Count == 0);
        //}
        //public void GetPossibleMovesEdgeTest()
        //{
        //    King king = new King(0, 2);
        //    HashSet<Position> expectedMoves = new HashSet<Position>
        //    {
        //        new ( 0, 3 ),
        //        new ( 0, 1 ),
        //        new ( 1, 1 ),
        //        new ( 1, 2 ),
        //        new ( 1, 3)
        //    };
        //    HashSet<Position> actualMoves = king.GetPossibleMoves();
        //    //TODO.Srikar there has to be a better way
        //    foreach (Position move in actualMoves)
        //    {
        //        expectedMoves.Remove(move);
        //    }

        //    Assert.IsTrue(expectedMoves.Count == 0);
        //}
    }
}