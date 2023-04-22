using CSharpChess.Models;
using CSharpChess.Models.Pieces;

namespace DotChess.Models.Pieces;

internal class Bishop : Piece
{
    private readonly Color _color;
    private readonly PieceType _pieceType;
    private readonly Position _position;

    public Bishop(Color color, Position position)
    {
        _color = color;
        _pieceType = PieceType.Bishop;
        _position = position;
    }

    public Color GetColor()
    {
        return _color;
    }

    public Position GetCurrentPosition()
    {
        return _position;
    }

    public PieceType GetPieceType()
    {
        return _pieceType;
    }

    public HashSet<Position> GetPossibleMoves()
    {
        //TODO.Srikar these should honestly be template methods
        var possibleMoves = new HashSet<Position>();
        var current = _position;

        //4,4
        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank + 1, current.File + 1))
        {
            possibleMoves.Add(new Position(current.Rank + 1, current.File + 1));
            current = new Position(current.Rank + 1, current.File + 1);
        }

        //3,4
        current = _position;

        //2,4
        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank - 1, current.File + 1))
        {
            possibleMoves.Add(new Position(current.Rank - 1, current.File + 1));
            current = new Position(current.Rank - 1, current.File + 1);
        }
        //2,3

        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank - 1, current.File - 1))
        {
            possibleMoves.Add(new Position(current.Rank - 1, current.File - 1));
            current = new Position(current.Rank - 1, current.File - 1);
        }

        //4,2
        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank + 1, current.File - 1))
        {
            possibleMoves.Add(new Position(current.Rank + 1, current.File - 1));
            current = new Position(current.Rank + 1, current.File - 1);
        }

        return possibleMoves;
    }
}