using System.Xml;

namespace CSharpChess.Models
{
    public class ChessRank
    {
        public ChessSquare[] file { get; set; }

        public ChessRank()
        {
            file = new ChessSquare[8];
            for (var i = 0; i < ChessBoard.BoardSize; i++)
            {
                file[i] = (new ChessSquare());
            }
        }

        public override string ToString()
        {
            String output = "";
            for (int i = 0; i < 8; i++)
            {
                output += file[i].ToString();
            }

            return output;
        }
    }
}