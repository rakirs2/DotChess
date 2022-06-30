namespace CSharpChess.Models
{
    public class ChessSquare
    {
        public char rank { get; set; }
        public int file { get; set; }
        public Boolean occupied { get; set; }
        public Boolean isWhiteOccupied { get; set; }
        public Boolean isBlackOccupied { get; set; }

        public ChessSquare()
        {
            this.occupied = false;
        }
    }
}