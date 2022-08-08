using System;
using System.ComponentModel.DataAnnotations;
using CSharpChess.Models;
using Microsoft.VisualBasic;

namespace CSharpChess.Pieces
{
    public class King : IPiece
    {

        protected Position position { get; set; }
        public King(int rank, int file)
        {
            position = new Position(rank, file);
        }

        public HashSet<Position> GetPossibleMoves()
        {
            HashSet<Position> possibleMoves = new HashSet<Position>();
            if (IsOnBoard(position.Rank + 1, position.File + 1))
            {
                possibleMoves.Add(new Position(position.Rank + 1, position.File + 1));
            }
            if (IsOnBoard(position.Rank + 1, position.File))
            {
                possibleMoves.Add(new Position(position.Rank + 1, position.File ));
            }
            if (IsOnBoard(position.Rank + 1, position.File - 1))
            {
                possibleMoves.Add(new Position(position.Rank + 1, position.File - 1));
            }
            if (IsOnBoard(position.Rank, position.File + 1))
            {
                possibleMoves.Add(new Position( position.Rank, position.File +1 ));
            }
            if (IsOnBoard(position.Rank, position.File - 1))
            {
                possibleMoves.Add(new Position(position.Rank, position.File - 1));
            }
            if (IsOnBoard(position.Rank - 1, position.File + 1))
            {
                possibleMoves.Add(new Position(position.Rank-1, position.File + 1));
            }
            if (IsOnBoard(position.Rank - 1, position.File))
            {
                possibleMoves.Add(new Position(position.Rank - 1, position.File));
            }
            if (IsOnBoard(position.Rank - 1, position.File - 1))
            {
                possibleMoves.Add(new Position(position.Rank - 1, position.File - 1));
            }

            return possibleMoves;
        }

        public static Boolean IsOnBoard(int rank, int file)
        {
            return rank >=0 && file >=0 && file<8 && rank < 8;
        }

        public Position GetPosition()
        {
            return position;
        }
    }
}

