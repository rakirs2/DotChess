namespace CSharpChess
{
    internal class ChessFile
    {

        public List<ChessSquare> ranks { get; set; }
        public ChessFile()
        {
            ranks = new List<ChessSquare>(8);
            for (int i = 0; i < 8; i++)
            {
                ranks.Append(new ChessSquare());
            }
        }
    }
}