using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CSharpChessTests")]

namespace CSharpChess.Models.Pieces
{
    public interface IPiece
    {
        //Files go vertical; ranks go horizontal. For now, treating it as 0-7
        PieceType GetPieceType();
        Color GetColor();
    }
    public enum Color
    {
        Black,
        White
    }

    public enum PieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn

    }
}

