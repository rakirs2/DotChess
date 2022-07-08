using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Models.Tests
{
    [TestClass()]
    public class ChessRankTests
    {
        [TestMethod()]
        public void EmptyRankTests()
        {
            ChessBoard chessBoard = new ChessBoard();


            Assert.AreEqual(".....│     │.....│     │.....│     │.....│     │", chessBoard.Ranks[0].ToString());
            Assert.AreEqual("     │.....│     │.....│     │.....│     │.....│", chessBoard.Ranks[1].ToString());
        }
    }
}