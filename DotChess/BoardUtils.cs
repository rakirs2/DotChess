namespace CSharpChess
{
    internal static class BoardUtils
    {
        internal static bool IsOnBoard(int rank, int file)
        {
            return rank >= 0 && rank < 8 && file >= 0 && file < 8;
        }
    }
}
