using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Models
{
    public class Position
    {
        public int Rank { get; set; }
        public int File { get; set; }

        public Position(int rank, int file)
        {
            this.Rank = rank;
            this.File = file;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Position)
            {
                return File == ((Position)obj).File && Rank == ((Position)obj).Rank;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Rank ^File;
        }
    }
}
