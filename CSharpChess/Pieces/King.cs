using System;
namespace CSharpChess.Pieces
{
    public class King : Piece
    {
        Boolean m_color;
        private Position m_currentPosition;

        public King(int rank, int file, Boolean color) 
        {
            m_color = color;
            m_currentPosition = new Position(rank, file);
        }
        
    }
}

