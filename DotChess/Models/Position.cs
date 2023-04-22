namespace DotChess.Models;

public class Position
{
    public Position(int rank, int file)
    {
        if (BoardUtils.IsOnBoard(rank, file))
        {
            //horizontal lines
            //numbers
            Rank = rank;
            //vertical lines
            // 'letters
            File = file;
        }
        else
        {
            throw new Exception("Not on board");
        }
    }

    public int Rank { get; }
    public int File { get; }

    public override bool Equals(object? obj)
    {
        if (obj is Position position) return File == position.File && Rank == position.Rank;
        return false;
    }

    /*
     * Simple XOR Hash on the Position. Should be safe
     */
    public override int GetHashCode()
    {
        return Rank ^ File;
    }
}