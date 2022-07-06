namespace CSharpChess.Models
{
    public class ChessFile
    {
        public List<ChessSquare> ranks { get; set; }
        public ChessFile()
        {
            ranks = new List<ChessSquare>(ChessBoard.BoardSize);
            for (int i = 0; i < ChessBoard.BoardSize; i++)
            {
                ranks.Add(new ChessSquare());
            }
        }
    }
}