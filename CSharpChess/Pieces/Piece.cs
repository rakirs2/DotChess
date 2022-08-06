using System;
namespace CSharpChess
{
    public interface Piece
    {
        internal Boolean move(int newRank, int newFile);
        public Boolean m_color
        {
            get;
            set;
        }
        internal Position m_currentPosition
        {
            get;
            set;
        }
    }
}

