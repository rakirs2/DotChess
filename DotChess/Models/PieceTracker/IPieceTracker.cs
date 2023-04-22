using CSharpChess.Models;
using CSharpChess.Models.Pieces;

namespace CSharpChess.PieceTracker;

public interface IPieceTracker
{
    public HashSet<Position> GetOccupiedPositions();

    public bool AddPiece(Position position, IPiece piece);
    //HashSet<Position> GetOccupiedPositionsByColor(Color color);
    //Position[][] GetPossibleMoves()
}


//public static Boolean IsOnBoard(int rank, int file)
//{
//    return rank >= 0 && file >= 0 && file < 8 && rank < 8;
//}