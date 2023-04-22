using CSharpChess.Models.Pieces;
using DotChess.Models;

namespace CSharpChess.Models.PieceTracker;

public interface IPieceTracker
{
    public HashSet<Position> GetOccupiedPositions();
    public bool IsOccupied(Position position);

    public bool AddPiece(Position position, IPiece piece);
    //HashSet<Position> GetOccupiedPositionsByColor(Color color);
    //Position[][] GetPossibleMoves()
}


//public static Boolean IsOnBoard(int rank, int file)
//{
//    return rank >= 0 && file >= 0 && file < 8 && rank < 8;
//}