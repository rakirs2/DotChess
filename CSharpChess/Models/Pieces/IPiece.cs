namespace CSharpChess.Models.Pieces
{
    public interface IPiece
    {
        //Files go vertical; ranks go horizontal. For now, treating it as 0-7
        public Color Color { get; }
        public PieceType PieceType { get; }

    }
    public enum Color{
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

