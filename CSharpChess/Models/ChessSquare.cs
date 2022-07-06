using System.Dynamic;

namespace CSharpChess.Models
{
    public class ChessSquare
    {
        public Boolean occupied { get; set; }

        public ChessSquare(int file, int rank)
        {

            this.occupied = false;
        }
        public ChessSquare()
        {
            this.occupied = false;
        }

    }
}