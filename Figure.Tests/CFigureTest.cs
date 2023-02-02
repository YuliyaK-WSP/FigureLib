using FigureLibrary;
namespace Figure.Tests
{
    [TestClass]
    public class CFigureTest
    {
        [TestMethod]
        public void CircleTest()
        {
            CFigure circle = new CFigure(2.0);
            Assert.AreEqual("Круг", circle.FigureType);
            Assert.AreEqual(12.57, circle.GetArea());
        }
        [TestMethod]
        public void TriangleTest()
        {
            CFigure triangle = new CFigure(2.0, 3.0, 4.0);
            Assert.AreEqual("Треугольник", triangle.FigureType);
        }
        [TestMethod]
        public void TriangleRightAngleTest()
        {
            CFigure triangle = new CFigure(6.0, 8.0, 10.0);
            Assert.AreEqual("Треугольник", triangle.FigureType);
            Assert.AreEqual(true, triangle.IsRightAngle());
        }
    }
}