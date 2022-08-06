using System;
namespace CSharpChess
{
    public class Position
    {
        int Rank { get; set; }
        int File { get; set; }

        public Position(int newRank, int newFile)
        {
            Rank = newRank;
            File = newFile;
        }
    }
}
   
