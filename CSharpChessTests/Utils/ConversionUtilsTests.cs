using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpChess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChess.Utils.Tests
{
    [TestClass()]
    public class ConversionUtilsTests
    {
        [TestMethod()]
        public void RankToArrayIndexNumberTest()
        {
            Assert.AreEqual(0, ConversionUtils.RankToArrayIndexNumber('a'));
            Assert.AreEqual(1, ConversionUtils.RankToArrayIndexNumber('b'));
            Assert.AreEqual(2, ConversionUtils.RankToArrayIndexNumber('c'));
            Assert.AreEqual(3, ConversionUtils.RankToArrayIndexNumber('d'));
            Assert.AreEqual(4, ConversionUtils.RankToArrayIndexNumber('e'));
            Assert.AreEqual(5, ConversionUtils.RankToArrayIndexNumber('f'));
            Assert.AreEqual(6, ConversionUtils.RankToArrayIndexNumber('g'));
            Assert.AreEqual(7, ConversionUtils.RankToArrayIndexNumber('h'));
        }
    }
}