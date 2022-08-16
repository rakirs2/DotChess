
using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using System.Runtime.CompilerServices;

namespace CSharpChess.PieceTracker;

internal interface IPieceTracker
{
    HashSet<Position> GetOccupiedPositions();
    HashSet<Position> GetOccupiedPositionsByColor(Color color);
    HashSet<Position> GetPossibleMoves(Position position);
}

//public HashSet<Position> GetPossibleMoves()
//{
//    HashSet<Position> possibleMoves = new HashSet<Position>();
//    TODO.Srikar simpilify this ?
//    if (IsOnBoard(position.Rank + 1, position.File + 1))
//    {
//        possibleMoves.Add(new Position(position.Rank + 1, position.File + 1));
//    }
//    if (IsOnBoard(position.Rank + 1, position.File))
//    {
//        possibleMoves.Add(new Position(position.Rank + 1, position.File));
//    }
//    if (IsOnBoard(position.Rank + 1, position.File - 1))
//    {
//        possibleMoves.Add(new Position(position.Rank + 1, position.File - 1));
//    }
//    if (IsOnBoard(position.Rank, position.File + 1))
//    {
//        possibleMoves.Add(new Position(position.Rank, position.File + 1));
//    }
//    if (IsOnBoard(position.Rank, position.File - 1))
//    {
//        possibleMoves.Add(new Position(position.Rank, position.File - 1));
//    }
//    if (IsOnBoard(position.Rank - 1, position.File + 1))
//    {
//        possibleMoves.Add(new Position(position.Rank - 1, position.File + 1));
//    }
//    if (IsOnBoard(position.Rank - 1, position.File))
//    {
//        possibleMoves.Add(new Position(position.Rank - 1, position.File));
//    }
//    if (IsOnBoard(position.Rank - 1, position.File - 1))
//    {
//        possibleMoves.Add(new Position(position.Rank - 1, position.File - 1));
//    }

//    return possibleMoves;
//}

//public static Boolean IsOnBoard(int rank, int file)
//{
//    return rank >= 0 && file >= 0 && file < 8 && rank < 8;
//}