namespace CSharpChess.Models.Pieces;

public class Rook : IPiece
{
    private readonly Color _color;
    private readonly PieceType _pieceType;
    private readonly Position _position;

    public Rook(Color color, Position position)
    {
        _color = color;
        _pieceType = PieceType.Rook;
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
        //TODO.Srikar consider simplifying this logic and adding it to other piece movements
        var possibleMoves = new HashSet<Position>();
        var current = _position;

        while (BoardUtils.IsOnBoard(current.Rank + 1, current.File))
        {
            possibleMoves.Add(new Position(current.Rank + 1, current.File));
            current = new Position(current.Rank + 1, current.File);
        }

        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank - 1, current.File))
        {
            possibleMoves.Add(new Position(current.Rank - 1, current.File));
            current = new Position(current.Rank - 1, current.File);
        }

        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank, current.File + 1))
        {
            possibleMoves.Add(new Position(current.Rank, current.File + 1));
            current = new Position(current.Rank, current.File + 1);
        }

        current = _position;
        while (BoardUtils.IsOnBoard(current.Rank, current.File - 1))
        {
            possibleMoves.Add(new Position(current.Rank, current.File - 1));
            current = new Position(current.Rank, current.File - 1);
        }

        return possibleMoves;
    }
}