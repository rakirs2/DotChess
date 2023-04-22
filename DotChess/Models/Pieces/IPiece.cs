using System.Runtime.CompilerServices;
using DotChess.Models;

[assembly: InternalsVisibleTo("DotChessTests")]

//TODO.Srikar switch movement to template method
namespace CSharpChess.Models.Pieces;

public interface IPiece
{
    //Files go vertical; ranks go horizontal. For now, treating it as 0-7
    /*
     * This method returns the PieceType Enum. It should theoretically help us get the type we want
     */
    PieceType GetPieceType();

    /*
     * Returns either Black or White
     */
    Color GetColor();

    /*
     * Returns the possible moves of a given piece on a board with no consideration of other pieces
     */
    Position GetCurrentPosition();
}

internal class Piece : IPiece
{
    private readonly Color _color;
    private readonly PieceType _pieceType;
    private Position _position;

    public PieceType GetPieceType()
    {
        return _pieceType;
    }

    public Color GetColor()
    {
        return _color;
    }

    public Position GetCurrentPosition()
    {
        return _position;
    }
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