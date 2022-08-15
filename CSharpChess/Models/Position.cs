using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Models
{
    public class Position
    {
        public int Rank { get;  }
        public int File { get; }

        public Position(int rank, int file)
        {
            this.Rank = rank;
            this.File = file;
        }

        public override bool Equals(object? obj)
        {

            if (obj is Position position)
            {
                return File == position.File && Rank == position.Rank;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Rank ^ File;
        }
    }
}
