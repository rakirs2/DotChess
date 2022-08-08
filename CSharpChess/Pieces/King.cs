using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace CSharpChess.Pieces
{
    public class King : IPiece
    {
        protected int rank {get; set; }
        protected int file { get; set; }
        public King(int rank, int file)
        {
            this.rank = rank;
            this.file = file;
        }

        public int GetRank()
        { return rank; }

        public int GetFile()
        {
            return file;
        }

        public HashSet<int[]> GetPossibleMoves()
        {
            HashSet<int[]> possibleMoves = new HashSet<int[]>();
            if (IsOnBoard(rank + 1, file + 1))
            {
                possibleMoves.Add(new int[] { rank + 1, file + 1 });
            }
            if (IsOnBoard(rank + 1, file))
            {
                possibleMoves.Add(new int[] { rank + 1, file });
            }
            if (IsOnBoard(rank + 1, file - 1))
            {
                possibleMoves.Add(new int[] { rank + 1, file - 1 });
            }
            if (IsOnBoard(rank, file + 1))
            {
                possibleMoves.Add(new int[] { rank, file + 1 });
            }
            if (IsOnBoard(rank, file - 1))
            {
                possibleMoves.Add(new int[] { rank, file - 1 });
            }
            if (IsOnBoard(rank-1, file + 1))
            {
                possibleMoves.Add(new int[] { rank-1, file + 1 });
            }
            if (IsOnBoard(rank -1, file))
            {
                possibleMoves.Add(new int[] { rank - 1, file });
            }
            if (IsOnBoard(rank - 1, file - 1))
            {
                possibleMoves.Add(new int[] { rank - 1, file - 1 });
            }

            return possibleMoves;
        }

        public static Boolean IsOnBoard(int rank, int file)
        {
            return rank >=0 && file >=0 && file<8 && rank < 8;
        }
    }
}

