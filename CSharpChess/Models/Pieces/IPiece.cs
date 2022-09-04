using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CSharpChessTests")]

//TODO.Srikar switch movement to template method
namespace CSharpChess.Models.Pieces
{
    public interface IPiece
    {
        //Files go vertical; ranks go horizontal. For now, treating it as 0-7
        PieceType GetPieceType();
        Color GetColor();
        //The default is vertical clockwise
        HashSet<Position> GetPossibleMoves();
        Position GetCurrentPosition();

    }
    public enum Color
    {
        Black,
        White
    }

    public enum PieceType
    {
        King,
        //TODO.Srikar Queen
        Queen,
        Rook,
        Bishop,
        Knight,
        //TODO.Srikar Pawn
        Pawn

    }
}

