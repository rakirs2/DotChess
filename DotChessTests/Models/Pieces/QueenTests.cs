﻿using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChessTests.Models.Pieces
{
    [TestClass()]
    public class QueenTests
    {
        [TestMethod()]
        public void BishopIdentityTest()
        {
            Queen black = new(Color.Black, new Position(0, 0));
            Queen white = new(Color.White, new Position(0, 0));
            Assert.AreEqual(PieceType.Queen, black.GetPieceType());
            Assert.AreEqual(black.GetPieceType(), white.GetPieceType());
            Assert.AreEqual(black.GetColor(), Color.Black);
            Position position = new(0, 0);
            Assert.AreEqual(position, black.GetCurrentPosition());
        }


        [TestMethod()]
        public void GetPossibleMovesTestLowerLeft()
        {
            Queen black = new(Color.Black, new Position(0, 0));
            HashSet<Position> possibleMoves = black.GetPossibleMoves();
            HashSet<Position> expectedMoves = new()
            {
                new Position(0, 1),
                new Position(0, 2),
                new Position(0, 3),
                new Position(0, 4),
                new Position(0, 5),
                new Position(0, 6),
                new Position(0, 7),
                new Position(1, 0),
                new Position(2, 0),
                new Position(3, 0),
                new Position(4, 0),
                new Position(5, 0),
                new Position(6, 0),
                new Position(7, 0),
                //bishop stuff
                new Position(1, 1),
                new Position(2, 2),
                new Position(3, 3),
                new Position(4, 4),
                new Position(5, 5),
                new Position(6, 6),
                new Position(7, 7)
            };
            Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
        }

        [TestMethod()]
        public void GetPossibleMovesLowerRight()
        {
            Queen black = new(Color.Black, new Position(0, 7));
            HashSet<Position> possibleMoves = black.GetPossibleMoves();
            HashSet<Position> expectedMoves = new()
            {
                new Position(0, 1),
                new Position(0, 2),
                new Position(0, 3),
                new Position(0, 4),
                new Position(0, 5),
                new Position(0, 6),
                new Position(0, 0),
                new Position(1, 7),
                new Position(2, 7),
                new Position(3, 7),
                new Position(4, 7),
                new Position(5, 7),
                new Position(6, 7),
                new Position(7, 7),
                new Position(7, 0),
                new Position(6, 1),
                new Position(5, 2),
                new Position(4, 3),
                new Position(3, 4),
                new Position(2, 5),
                new Position(1, 6)
            };
            Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
        }
        [TestMethod()]
        public void GetPossibleMovesMiddle()
        {
            Queen black = new(Color.Black, new Position(3, 3));
            HashSet<Position> possibleMoves = black.GetPossibleMoves();
            HashSet<Position> expectedMoves = new()
            {
                new Position(3, 1),
                new Position(3, 2),
                new Position(3, 0),
                new Position(3, 4),
                new Position(3, 5),
                new Position(3, 6),
                new Position(3, 7),
                new Position(1, 3),
                new Position(2, 3),
                new Position(0, 3),
                new Position(4, 3),
                new Position(5, 3),
                new Position(6, 3),
                new Position(7, 3),
                new Position(2, 2),
                new Position(1, 1),
                new Position(0, 0),
                new Position(4, 4),
                new Position(5, 5),
                new Position(6, 6),
                new Position(7, 7),
                new Position(4, 2),
                new Position(5, 1),
                new Position(6, 0),
                new Position(2, 4),
                new Position(1, 5),
                new Position(0, 6),
                
            };
            Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
        }
    }
}