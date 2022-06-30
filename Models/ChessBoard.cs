namespace CSharpChess.Models
{
    public class ChessBoard
    {
        public const int boardSize = 8;
        public List<ChessFile> files { get; set; }
        public ChessBoard()
        {
            //TODO override to strings to print out a chess board

            this.files = new List<ChessFile>(boardSize);

            for (int i = 0; i < boardSize; i++)
            {
                this.files.Add(new ChessFile());
            }
        }
    }
}