using GeometricFigures;
using GeometricFugures;
using GeometricFugures.Enums;
using GeometricFugures.Exceptions;
using GeometricFugures.Factories;
using GeometricFugures.Figures;
using GeometricFugures.Interfaces;

namespace Tests
{
    public class UnitTest1
    {

        [Fact]
        public void CircleAreaTest()
        {
            var radius = 5d;

            IFigureFactory factory = new FigureFactory();

            IFigure circle = factory.GetFigure(FigureType.Circle, radius);

            var expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expectedArea, circle.CalculateArea(), Constants.AccuracyError);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var sideA = 5d;
            var sideB = 5d;
            var sideC = 6d;

            IFigureFactory factory = new FigureFactory();

            var triangle = factory.GetFigure(FigureType.Triangle, sideA, sideB, sideC);

            var expectedArea = 12d;

            Assert.Equal(expectedArea, triangle.CalculateArea(), Constants.AccuracyError);
        }


        [Fact]
        public void IsRightTriangleTest()
        {
            var sideA = 6d;
            var sideB = 8d;
            var sideC = 10d;

            IFigureFactory factory = new FigureFactory();

            var triangle = (Triangle)factory.GetFigure(FigureType.Triangle,sideA, sideB, sideC);

            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void IsNotRightTriangleTest()
        {
            var sideA = 3d;
            var sideB = 4d;
            var sideC = 6d;

            IFigureFactory factory = new FigureFactory();

            var triangle = (Triangle)factory.GetFigure(FigureType.Triangle,sideA, sideB, sideC);

            Assert.False(triangle.IsRight());
        }

        [Fact]

        public void NonExsistantTriangleTest() 
        {
            var sideA = 3d;
            var sideB = 4d;
            var sideC = 7d;

            IFigureFactory factory = new FigureFactory();
            Assert.Throws<TriangleDoNotExistsException>(() => factory.GetFigure(FigureType.Triangle, sideA, sideB, sideC));
        }

        [Fact]

        public void BadParameterTest()
        {
            var radius = 0;
            IFigureFactory factory = new FigureFactory();
            Assert.Throws<InvalidParameterException>(() => factory.GetFigure(FigureType.Circle, radius));
        }

        [Fact]
        public void WrongAmountOfParametersTest() 
        {
            var radius = 2;
            var unnecessary = 24;
            IFigureFactory factory = new FigureFactory();
            Assert.Throws<ArgumentException>(() => factory.GetFigure(FigureType.Circle, radius,unnecessary));
        }

    }
}