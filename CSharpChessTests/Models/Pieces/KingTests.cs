using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;
using CSharpChess.Models.Pieces;

namespace CSharpChess.Pieces.Tests
{
    [TestClass()]
    public class KingTests
    {
        [TestMethod()]
        public void KingTest()
        {
            King Black = new(Color.Black);
            King White = new(Color.White);
            Assert.AreEqual(Black.GetPieceType(), PieceType.King);
            Assert.AreEqual(Black.GetPieceType(), White.GetPieceType());
            Assert.AreEqual(Black.GetColor(), Color.Black);

        }
    }
}