using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Pieces
{
    internal class PieceTracker
    {
        private Dictionary<int[], IPiece> pieces { get; set; }
        internal PieceTracker()
        {
            pieces = new Dictionary<int[], IPiece>();
        }
        
    }
}
