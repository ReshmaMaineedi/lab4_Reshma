//Author: Reshma Maineedi
//Student ID: 8983123
using NUnit.Framework;
using NUnitDemonstration;

namespace TestCases
{
    public class TriangleTest
    {
        [TestFixture]
        public class TriangleTest1
        {
            // 1. Equilateral Triangle
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 2. Right Triangle
            [Test]
            public void ValidTriangle_Input90and45and45_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 90;
                int secondAngle = 45;
                int thirdAngle = 45;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 3. Obtuse Triangle
            [Test]
            public void ValidTriangle_Input120and30and30_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 120;
                int secondAngle = 30;
                int thirdAngle = 30;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 4. Acute Triangle
            [Test]
            public void ValidTriangle_Input70and60and50_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 70;
                int secondAngle = 60;
                int thirdAngle = 50;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 5. Invalid Triangle (Sum greater than 180)
            [Test]
            public void InvalidTriangle_Input100and50and50_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 100;
                int secondAngle = 50;
                int thirdAngle = 50;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 6. Invalid Triangle (Sum less than 180)
            [Test]
            public void InvalidTriangle_Input60and60and50_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 50;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 7. Zero Angle Case
            [Test]
            public void InvalidTriangle_Input0and90and90_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 0;
                int secondAngle = 90;
                int thirdAngle = 90;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 8. Negative Angle Case
            [Test]
            public void InvalidTriangle_InputNeg50and100and130_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = -50;
                int secondAngle = 100;
                int thirdAngle = 130;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 9. All Angles 0
            [Test]
            public void InvalidTriangle_Input0and0and0_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 0;
                int secondAngle = 0;
                int thirdAngle = 0;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            // 10. One angle greater than 180
            [Test]
            public void InvalidTriangle_Input190and10and10_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 190;
                int secondAngle = 10;
                int thirdAngle = 10;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
