namespace CSharpChess.Models
{
    public class ChessFile
    {
        public ChessSquare[] ranks { get; set; }
        public ChessFile()
        {
            ranks = new ChessSquare[8];
            for (var i = 0; i < ChessBoard.BoardSize; i++)
            {
                ranks[i]= (new ChessSquare());
            }
        }
    }
}