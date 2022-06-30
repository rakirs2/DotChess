using System.Dynamic;

namespace CSharpChess
{
    internal class ChessBoard
    {
        public List<ChessFile> files { get;}
        public ChessBoard()
        {
            //TODO populate files
            //this.files = new List<ChessFile>(8);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i);
            }
        } 


    }
}