namespace CSharpChess.Models
{
    public class ChessFile
    {
        public List<ChessSquare> ranks { get; set; }
        public ChessFile()
        {
            ranks = new List<ChessSquare>(ChessBoard.boardSize);
            for (int i = 0; i < ChessBoard.boardSize; i++)
            {
                ranks.Add(new ChessSquare());
            }
        }
    }
}