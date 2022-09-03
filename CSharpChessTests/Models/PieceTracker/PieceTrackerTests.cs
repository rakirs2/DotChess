using CSharpChess.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChess.Models.PieceTracker.Tests
{
    [TestClass()]
    public class PieceTrackerTests
    {
        [TestMethod()]
        public void GetOccupiedPositionsTest()
        {
            PieceTracker pieceTracker = new PieceTracker();
            Assert.AreEqual(0, pieceTracker.GetOccupiedPositions().Count);
        }

        [TestMethod()]
        public void SinglePieceOnBoard()
        {
            PieceTracker pieceTracker = new PieceTracker();
            Position position = new Position(7, 4);
            King BlackKing = new King(Pieces.Color.Black, position);

            pieceTracker.AddPiece(position, BlackKing);

            Assert.AreEqual(1, pieceTracker.GetOccupiedPositions().Count);
        }
        [TestMethod()]
        public void TwoPiecesOnBoard()
        {
            PieceTracker pieceTracker = new PieceTracker();
            Position position1 = new Position(1, 4);
            King BlackKing = new King(Pieces.Color.Black, position1);

            pieceTracker.AddPiece(position1, BlackKing);
            Position position2 = new Position(0, 4);
            King WhiteKing = new King(Pieces.Color.White, position2);

            pieceTracker.AddPiece(position2, WhiteKing);


            Assert.AreEqual(2, pieceTracker.GetOccupiedPositions().Count);
        }
    }
}