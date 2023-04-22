using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using DotChess.Models;
using DotChess.Models.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotChessTests.Models.Pieces;

[TestClass]
public class BishopTests
{
    [TestMethod]
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


    [TestMethod]
    public void GetPossibleMovesTestLowerLeft()
    {
        Bishop black = new(Color.Black, new Position(0, 0));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
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

    [TestMethod]
    public void GetPossibleMovesLowerRight()
    {
        Bishop black = new(Color.Black, new Position(0, 7));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
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

    [TestMethod]
    public void GetPossibleMovesMiddle()
    {
        Bishop black = new(Color.Black, new Position(3, 3));
        var possibleMoves = black.GetPossibleMoves();
        HashSet<Position> expectedMoves = new()
        {
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
            new Position(0, 6)
        };
        Assert.IsTrue(possibleMoves.SetEquals(expectedMoves));
    }
}