using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLib;

namespace UnitTestAssignment
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Test_DefaultConstructor()
        {
            Point point = new Point();
            Assert.AreEqual(0, point.getX());
            Assert.AreEqual(0, point.getY());
        }

        [TestMethod]
        public void Test_ExplicitConstructor()
        {
            const double testX = 3;
            const double testY = 4;

            Point point = new Point(testX, testY);

            Assert.AreEqual(testX, point.getX());
            Assert.AreEqual(testY, point.getY());
        }

        [TestMethod]
        public void Test_Stretch()
        {
            const double testX = 3;
            const double testY = 4;
            const double testStretch = 3;

            Point point = new Point(testX, testY);

            point.stretch(testStretch);
            Assert.AreEqual(testX * testStretch, point.getX());
            Assert.AreEqual(testY * testStretch, point.getY());
        }

        [TestMethod]
        public void Test_Distance()
        {
            const double testX1 = 3;
            const double testY1 = 4;
            const double testX2 = 2;
            const double testY2 = 1;

            Point point1 = new Point(testX1, testY1);
            Point point2 = new Point(testX2, testY2);

            Assert.AreEqual(Math.Abs(Math.Pow((Math.Pow(testX2 - testX1, 2) + Math.Pow(testY1 - testY2, 2)), 0.5)), point1.distance(point2));
        }

        [TestMethod]
        public void Test_Rotate()
        {
            const double testX = 1;
            const double testY = 0;
            const double testDeg = 90;

            Point point = new Point(testX, testY);
            point.rotate(testDeg);

//            Assert.AreEqual(0, point.getX());
//            Assert.AreEqual(1, point.getY());
            Assert.IsTrue(Math.Abs(point.getX() - 0) < 0.00001);
            Assert.IsTrue(Math.Abs(point.getY() - 1) < 0.00001);
        }

        [TestMethod]
        public void Test_ToString()
        {
            const double testX = 3;
            const double testY = 4;
            string testString = "(" + testX.ToString("N1") + ", " + testY.ToString("N1") + ")";

            Point point = new Point(testX, testY);

            Assert.AreEqual(testString, point.ToString());
        }

        [TestMethod]
        public void Test_LessThan()
        {
            const double testX1 = 3;
            const double testY1 = 4;
            const double testX2 = 2;
            const double testY2 = 1;

            Point point1 = new Point(testX1, testY1);
            Point point2 = new Point(testX2, testY2);

            Assert.IsTrue(point2 < point1);
        }

        [TestMethod]
        public void Test_GreaterThan()
        {
            const double testX1 = 3;
            const double testY1 = 4;
            const double testX2 = 2;
            const double testY2 = 1;

            Point point1 = new Point(testX1, testY1);
            Point point2 = new Point(testX2, testY2);

            Assert.IsTrue(point1 > point2);
        }
    }
}
