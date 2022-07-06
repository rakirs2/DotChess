using CSharpChess.Models;

namespace CSharpChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();
            Console.WriteLine(chessBoard);
        }
    }
}