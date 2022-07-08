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
    public class ChessSquareTests
    {
        [TestMethod()]
        public void UnoccupiedSquareWhite()
        {
            ChessSquare square = new ChessSquare();
            square.IsBlack = false;
            square.Occupied = false;
            
            Assert.AreEqual("     ", square.ToString() );
        }
        [TestMethod()]
        public void UnoccupiedSquareBlack()
        {
            ChessSquare square = new ChessSquare
            {
                IsBlack = true,
                Occupied = false
            };

            Assert.AreEqual(".....", square.ToString());
        }
    }
}