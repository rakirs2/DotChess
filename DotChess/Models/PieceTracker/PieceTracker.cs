using CSharpChess.Models.Pieces;
using CSharpChess.PieceTracker;

namespace CSharpChess.Models.PieceTracker;

public class PieceTracker : IPieceTracker

{
    public PieceTracker()
    {
        Pieces = new Dictionary<Position, IPiece>();
    }

    private Dictionary<Position, IPiece> Pieces { get; }


    public HashSet<Position> GetOccupiedPositions()
    {
        var positions = new HashSet<Position>();
        foreach (var piece in Pieces) positions.Add(piece.Key);
        return positions;
    }

    public bool IsOccupied(Position position)
    {
        return Pieces.ContainsKey(position);
    }

    public bool AddPiece(Position position, IPiece piece)
    {
        if (Pieces.ContainsKey(position))
        {
            return false;
        }

        Pieces.Add(position, piece);
        return true;
    }
}