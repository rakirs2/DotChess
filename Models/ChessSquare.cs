namespace CSharpChess.Models
{
    public class ChessSquare
    {

        public Boolean occupied { get; set; }


        public ChessSquare()
        {
            this.occupied = false;
        }
    }
}