using CSharpChess.Models;

namespace CSharpChess
{
    public interface IPiece
    {
        //Files go vertical; ranks go horizontal. For now, treating it as 0-7
        Position GetPosition();
        Color GetColor();
        PieceType GetPieceType();
    }
}

