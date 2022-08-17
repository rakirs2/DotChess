using System;
using System.ComponentModel.DataAnnotations;
using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using Microsoft.VisualBasic;

namespace CSharpChess.Pieces
{
    public class King : IPiece
    {
        private readonly Color _color;
        private readonly PieceType _pieceType;

        public King(Color color)
        {
            _color = color;
            _pieceType = PieceType.King;
        }

        public Color GetColor()
        {
            return _color;
        }

        public PieceType GetPieceType()
        {
            return _pieceType;
        }
    }
}

