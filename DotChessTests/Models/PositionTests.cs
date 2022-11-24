using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChess.Models.Tests
{
    [TestClass()]
    public class PositionTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Position pos1 = new Position(1, 3);
            Position pos2 = new Position(1, 3);
            Assert.AreEqual(pos1, pos2);
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Position pos1 = new Position(1, 3);
            Position pos2 = new Position(1, 3);
            Assert.AreEqual(pos1.GetHashCode(), pos2.GetHashCode());
        }
    }
}