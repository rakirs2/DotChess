using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpChess.Models;

namespace CSharpChess.Tests
{
    [TestClass()]
    public class ChessBoardTests
    {
        [TestMethod]
        public void ChessBoardDimensions()
        {
            ChessBoard board = new ChessBoard();
            Assert.AreEqual(board.Files.Length, 8);
            Assert.AreEqual(board.Files[0].ranks.Length, 8);
        }
    }
}