using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using DotChess.Models;
using DotChess.Models.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotChessTests.Models.ChessBoard;

[TestClass]
public class ChessBoardTests
{
    private Random _random =new();
    private readonly HashSet<Position> _positions = new();
    [TestInitialize]
    public void Setup()
    {
        _random = new Random();
    }

    [TestCleanup]
    public void TearDown()
    { 
        _positions.Clear();
    }
    [TestMethod]
    public void GetOccupiedPositionsTest()
    {
        var pieceTracker = new CSharpChess.Models.PieceTracker.ChessBoard();
        Assert.AreEqual(0, pieceTracker.GetOccupiedPositions().Count);
    }

    [TestMethod]
    public void SinglePieceOnBoard()
    {
        var pieceTracker = new CSharpChess.Models.PieceTracker.ChessBoard();
        var position = new Position(_random.Next(7), _random.Next(7));
        var blackKing = new King(Color.Black, position);

        pieceTracker.AddPiece(position, blackKing);

        Assert.AreEqual(1, pieceTracker.GetOccupiedPositions().Count);
    }

    [TestMethod]
    public void TwoPiecesOnBoard()
    {
        
        var pieceTracker = new CSharpChess.Models.PieceTracker.ChessBoard();
        var position1 = GenerateUniqueTestPosition();
        var blackKing = new King(Color.Black, position1);

        pieceTracker.AddPiece(position1, blackKing);
        var position2 = GenerateUniqueTestPosition();
        var whiteKing = new King(Color.White, position2);

        pieceTracker.AddPiece(position2, whiteKing);


        Assert.AreEqual(2, pieceTracker.GetOccupiedPositions().Count);
    }

    internal Position GenerateUniqueTestPosition()
    {
        var currentPosition = new Position(_random.Next(NumberOfRanks), _random.Next(NumberOfFiles));
        while (_positions.Contains(currentPosition))
        {
            currentPosition = new Position(_random.Next(NumberOfRanks), _random.Next(NumberOfFiles));
        }
        _positions.Add(currentPosition);
        return currentPosition;
    }

    private const int NumberOfRanks = 7;
    private const int NumberOfFiles = 7;
}