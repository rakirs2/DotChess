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
            Assert.AreEqual(board.Ranks.Length, 8);
            Assert.AreEqual(board.Ranks[0].file.Length, 8);
        }
        [TestMethod]
        public void EmptyChessBoardToString()
        {
            ChessBoard board = new ChessBoard();
            Assert.AreEqual("┌─┬─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┐\n" +
                                    "│8│     │.....│     │.....│     │.....│     │.....│\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│7│.....│     │.....│     │.....│     │.....│     │\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│6│     │.....│     │.....│     │.....│     │.....│\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│5│.....│     │.....│     │.....│     │.....│     │\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│4│     │.....│     │.....│     │.....│     │.....│\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│3│.....│     │.....│     │.....│     │.....│     │\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│2│     │.....│     │.....│     │.....│     │.....│\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│1│.....│     │.....│     │.....│     │.....│     │\n" +
                                    "├─┼─────┼─────┼─────┼─────┼─────┼─────┼─────┼─────┤\n" +
                                    "│ │  a  │  b  │  c  │  d  │  e  │  f  │  g  │  h  │\n" +
                                    "└─┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┘\n", board.ToString());
        }
    }
}