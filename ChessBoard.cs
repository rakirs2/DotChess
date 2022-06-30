using System.Dynamic;

namespace CSharpChess
{
    internal class ChessBoard
    {
        public List<ChessFile> files { get; set; }
        public ChessBoard()
        {
            //TODO override to strings to print out a chess board

            this.files = new List<ChessFile>(8);

            for (int i = 0; i < 8; i++)
            {
                this.files.Add(new ChessFile());
                Console.WriteLine(this.files.Count);
            }
        } 


    }
}