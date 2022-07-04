using System.Dynamic;

namespace CSharpChess.Models
{
    public class ChessSquare
    {
        public Boolean occupied { get; set; }
        public char file { get; set; }
        public int rank { get; set; }

        public ChessSquare(int file, int rank)
        {

            this.occupied = false;
        }

        private char fileToLetter(int file)
        {
            return 'a';
        }
    }
}