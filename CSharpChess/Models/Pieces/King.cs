using System;
using System.ComponentModel.DataAnnotations;
using CSharpChess.Models;
using CSharpChess.Models.Pieces;
using Microsoft.VisualBasic;

namespace CSharpChess.Pieces
{
    internal class King : IPiece
    {
        public Color Color { get; }
        public PieceType PieceType { get; }

        public King (Color color)
        {
            Color = color;
            PieceType = PieceType.King;
        }
    }
}

