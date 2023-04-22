using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChessTests.Models.Pieces;

[TestClass]
public class RookTests
{
    [TestMethod]
    public void BishopIdentityTest()
    {
        Rook black = new(Color.Black, new Position(0, 0));
        Rook white = new(Color.White, new Position(0, 0));
        Assert.AreEqual(PieceType.Rook, black.GetPieceType());
        Assert.AreEqual(black.GetPieceType(), white.GetPieceType());
        Assert.AreEqual(black.GetColor(), Color.Black);
        Position position = new(0, 0);
        Assert.AreEqual(position, black.GetCurrentPosition());
    }


    [TestMethod]
    public void GetPossibleMovesTestLowerLeft()
    {
        Rook black = new(Color.Black, new Position(0, 0));
        var possibleMoves = black.GetPossibleMoves();
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
            new Position(7, 0)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }

    [TestMethod]
    public void GetPossibleMovesLowerRight()
    {
        Rook black = new(Color.Black, new Position(0, 7));
        var possibleMoves = black.GetPossibleMoves();
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
            new Position(7, 7)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }

    [TestMethod]
    public void GetPossibleMovesMiddle()
    {
        Rook black = new(Color.Black, new Position(3, 3));
        var possibleMoves = black.GetPossibleMoves();
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
            new Position(7, 3)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }
}