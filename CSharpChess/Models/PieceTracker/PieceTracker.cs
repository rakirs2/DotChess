using CSharpChess.Models.Pieces;
using CSharpChess.PieceTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Models.PieceTracker
{
    public class PieceTracker : IPieceTracker

    {
        private Dictionary<Position, IPiece> Pieces { get; }

        public PieceTracker()
        {
            Pieces = new Dictionary<Position, IPiece>();
        }


        public HashSet<Position> GetOccupiedPositions()
        {
            HashSet<Position> positions = new HashSet<Position>();
            foreach (var piece in Pieces)
            {
                positions.Add(piece.Key);
            }
            return positions;
        }

        public bool AddPiece(Position position, IPiece piece)
        {
            if (Pieces.ContainsKey(position))
            {
                return false;
            }
            else
            {
                Pieces.Add(position, piece);
                return true;
            }
        }
    }
}
