﻿using DotChess;
using DotChess.Models;

namespace CSharpChess.Models.Pieces;

public class Knight : IPiece
{
    private readonly Color _color;
    private readonly PieceType _pieceType;
    private readonly Position _position;

    public Knight(Color color, Position position)
    {
        _color = color;
        _pieceType = PieceType.Knight;
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
        //assuming 3,3
        var possibleMoves = new HashSet<Position>();
        //5,4
        if (BoardUtils.IsOnBoard(_position.Rank + 2, _position.File + 1))
            possibleMoves.Add(new Position(_position.Rank + 2, _position.File + 1));
        //4,5
        if (BoardUtils.IsOnBoard(_position.Rank + 1, _position.File + 2))
            possibleMoves.Add(new Position(_position.Rank + 1, _position.File + 2));
        //2,5
        if (BoardUtils.IsOnBoard(_position.Rank - 1, _position.File + 2))
            possibleMoves.Add(new Position(_position.Rank - 1, _position.File + 2));
        //1,4
        if (BoardUtils.IsOnBoard(_position.Rank - 2, _position.File + 1))
            possibleMoves.Add(new Position(_position.Rank - 2, _position.File + 1));
        //1,2
        if (BoardUtils.IsOnBoard(_position.Rank - 2, _position.File - 1))
            possibleMoves.Add(new Position(_position.Rank - 2, _position.File - 1));
        //2,1
        if (BoardUtils.IsOnBoard(_position.Rank - 1, _position.File - 2))
            possibleMoves.Add(new Position(_position.Rank - 1, _position.File - 2));
        //4,1
        if (BoardUtils.IsOnBoard(_position.Rank + 1, _position.File - 2))
            possibleMoves.Add(new Position(_position.Rank + 1, _position.File - 2));
        //5,2
        if (BoardUtils.IsOnBoard(_position.Rank + 2, _position.File - 1))
            possibleMoves.Add(new Position(_position.Rank + 2, _position.File - 1));

        return possibleMoves;
    }
}