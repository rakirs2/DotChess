using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using Microsoft.VisualBasic;

namespace CSharpChess.Pieces
{
    public class King : IPiece
    {
        private readonly Color _color;
        private readonly PieceType _pieceType;
        private Position _position;

        public King(Color color, Position position)
        {
            _color = color;
            _pieceType = PieceType.King;
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
            HashSet<Position> possibleMoves = new HashSet<Position>();
            //4,3
            if (BoardUtils.IsOnBoard(_position.Rank + 1, _position.File))
            {
                possibleMoves.Add(new Position(_position.Rank + 1, _position.File));
            }
            //4,4
            if (BoardUtils.IsOnBoard(_position.Rank + 1, _position.File +1))
            {
                possibleMoves.Add(new Position(_position.Rank + 1, _position.File + 1));
            }
            //3,4
            if (BoardUtils.IsOnBoard(_position.Rank, _position.File + 1))
            {
                possibleMoves.Add(new Position(_position.Rank, _position.File + 1));
            }
            //2,4
            if (BoardUtils.IsOnBoard(_position.Rank-1, _position.File + 1))
            {
                possibleMoves.Add(new Position(_position.Rank-1, _position.File + 1));
            }
            //2,3
            if (BoardUtils.IsOnBoard(_position.Rank - 1, _position.File))
            {
                possibleMoves.Add(new Position(_position.Rank - 1, _position.File));
            }
            //2,2
            if (BoardUtils.IsOnBoard(_position.Rank - 1, _position.File-1))
            {
                possibleMoves.Add(new Position(_position.Rank - 1, _position.File-1));
            }
            //3,2
            if (BoardUtils.IsOnBoard(_position.Rank , _position.File - 1))
            {
                possibleMoves.Add(new Position(_position.Rank , _position.File - 1));
            }
            //4,2
            if (BoardUtils.IsOnBoard(_position.Rank+1, _position.File - 1))
            {
                possibleMoves.Add(new Position(_position.Rank+1, _position.File - 1));
            }

            return possibleMoves;
        }
    }
}

