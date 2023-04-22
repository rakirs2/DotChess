namespace DotChess;

internal static class BoardUtils
{
    internal static bool IsOnBoard(int rank, int file)
    {
        return rank is >= 0 and < 8 && file is >= 0 and < 8;
    }
}