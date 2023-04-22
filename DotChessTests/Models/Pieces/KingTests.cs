using CSharpChess.Models.Pieces;
using DotChess.Models;
using DotChess.Models.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotChessTests.Models.Pieces;

[TestClass]
public class KingTests
{
    [TestMethod]
    public void KingTest()
    {
        King black = new(Color.Black, new Position(0, 0));
        King white = new(Color.White, new Position(0, 0));
        Assert.AreEqual(black.GetPieceType(), PieceType.King);
        Assert.AreEqual(black.GetPieceType(), white.GetPieceType());
        Assert.AreEqual(black.GetColor(), Color.Black);
        Position position = new(0, 0);
        Assert.AreEqual(position, black.GetCurrentPosition());
    }

    [TestMethod]
    public void KingMiddleGetPossibleMoves()
    {
        King black = new(Color.Black, new Position(3, 3));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
            new Position(4, 3),
            new Position(4, 4),
            new Position(3, 4),
            new Position(2, 4),
            new Position(2, 3),
            new Position(2, 2),
            new Position(3, 2),
            new Position(4, 2)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }

    [TestMethod]
    public void KingCorner()
    {
        King black = new(Color.Black, new Position(0, 0));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
            new Position(1, 0),
            new Position(1, 1),
            new Position(0, 1)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }

    [TestMethod]
    public void KingEdge()
    {
        King black = new(Color.Black, new Position(4, 0));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
            new Position(5, 0),
            new Position(5, 1),
            new Position(4, 1),
            new Position(3, 1),
            new Position(3, 0)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }
}