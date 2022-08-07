using System;
namespace CSharpChess.Pieces
{
    public class King : Piece
    {
        bool Piece.m_color { get; set; }
        private Position m_currentPosition;

        public King(int rank, int file, Boolean color) 
        {
            Piece.m_color = color;
            m_currentPosition = new Position(rank, file);
        }

        
        Position Piece.m_currentPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        bool Piece.move(int newRank, int newFile)
        {
            throw new NotImplementedException();
        }
    }
}

