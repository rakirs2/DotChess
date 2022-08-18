using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;

namespace CSharpChess
{
    internal static class BoardUtils
    {
        internal static bool IsOnBoard(int rank, int  file)
        {
            return rank >= 0 && rank < 8 && file >= 0 && file < 8;
        }
    }
}
