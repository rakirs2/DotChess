﻿using System.Dynamic;

namespace CSharpChess.Models
{
    public class ChessSquare
    {
        public  bool Occupied { get; set; }
        public bool IsBlack { get; set; }

        

        public ChessSquare(int file, int rank)
        {
            Occupied = false;
            IsBlack = false;
        }
        public ChessSquare()
        {
            Occupied = false;
            IsBlack= false;
            
        }

        public override string ToString()
        {
            return IsBlack ? "....." : "     ";
        }
    }
}