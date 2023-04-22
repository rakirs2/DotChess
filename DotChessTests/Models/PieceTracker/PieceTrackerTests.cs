using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using CSharpChess.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotChessTests.Models.PieceTracker;

[TestClass]
public class PieceTrackerTests
{
    [TestMethod]
    public void GetOccupiedPositionsTest()
    {
        var pieceTracker = new CSharpChess.Models.PieceTracker.PieceTracker();
        Assert.AreEqual(0, pieceTracker.GetOccupiedPositions().Count);
    }

    [TestMethod]
    public void SinglePieceOnBoard()
    {
        var pieceTracker = new CSharpChess.Models.PieceTracker.PieceTracker();
        var position = new Position(7, 4);
        var BlackKing = new King(Color.Black, position);

        pieceTracker.AddPiece(position, BlackKing);

        Assert.AreEqual(1, pieceTracker.GetOccupiedPositions().Count);
    }

    [TestMethod]
    public void TwoPiecesOnBoard()
    {
        var pieceTracker = new CSharpChess.Models.PieceTracker.PieceTracker();
        var position1 = new Position(1, 4);
        var BlackKing = new King(Color.Black, position1);

        pieceTracker.AddPiece(position1, BlackKing);
        var position2 = new Position(0, 4);
        var WhiteKing = new King(Color.White, position2);

        pieceTracker.AddPiece(position2, WhiteKing);


        Assert.AreEqual(2, pieceTracker.GetOccupiedPositions().Count);
    }
}