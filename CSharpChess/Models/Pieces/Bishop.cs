﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Models.Pieces
{
    public class Bishop : IPiece
    {
        private readonly Color _color;
        private readonly PieceType _pieceType;
        private Position _position;
        public Bishop(Color color, Position position)
        {
            _color = color;
            _pieceType = PieceType.Bishop;
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
            //TODO.Srikar consider simplifying this logic and adding it to other piece movements
            HashSet<Position> possibleMoves = new HashSet<Position>();
            var current = _position;

            //4,4
            current = _position;
            while (BoardUtils.IsOnBoard(current.Rank + 1, current.File + 1))
            {
                possibleMoves.Add(new Position(current.Rank + 1, current.File + 1));
            }
            //3,4
            current = _position;

            //2,4
            current = _position;
            while (BoardUtils.IsOnBoard(current.Rank - 1, current.File + 1))
            {
                possibleMoves.Add(new Position(current.Rank - 1, current.File + 1));
            }
            //2,3

            current = _position;
            while (BoardUtils.IsOnBoard(current.Rank - 1, current.File - 1))
            {
                possibleMoves.Add(new Position(current.Rank - 1, current.File - 1));
            }
            //4,2
            current = _position;
            while (BoardUtils.IsOnBoard(current.Rank + 1, current.File - 1))
            {
                possibleMoves.Add(new Position(current.Rank + 1, current.File - 1));
            }

            return possibleMoves;

        }
    }
}
