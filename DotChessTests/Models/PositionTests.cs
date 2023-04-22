using CSharpChess.Models;
using DotChess.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotChessTests.Models;

[TestClass]
public class PositionTests
{
    [TestMethod]
    public void EqualsTest()
    {
        var pos1 = new Position(1, 3);
        var pos2 = new Position(1, 3);
        Assert.AreEqual(pos1, pos2);
    }

    [TestMethod]
    public void GetHashCodeTest()
    {
        var pos1 = new Position(1, 3);
        var pos2 = new Position(1, 3);
        Assert.AreEqual(pos1.GetHashCode(), pos2.GetHashCode());
    }
}