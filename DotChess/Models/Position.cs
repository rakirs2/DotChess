namespace CSharpChess.Models;

public class Position
{
    public Position(int rank, int file)
    {
        if (BoardUtils.IsOnBoard(rank, file))
        {
            //horizontal lines
            Rank = rank;
            //vertical lines
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

    public override int GetHashCode()
    {
        return Rank ^ File;
    }
}