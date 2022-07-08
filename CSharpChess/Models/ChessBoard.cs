namespace CSharpChess.Models
{
    public class ChessBoard
    {
        public const int BoardSize = 8;
        public ChessRank[] Ranks { get; set; }

        public ChessBoard()
        {
            //TODO override to strings to print out a chess board

            Ranks = new ChessRank[8];

            for (var i = 0; i < BoardSize; i++)
            {
                Ranks[i]=new ChessRank();
            }
        }


        public override string ToString()
        {
            String output = "not a chessboard yet";
                return output;
            }
    }
}