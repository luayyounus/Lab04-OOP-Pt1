using System;
using Xunit;
using ZooApp.Classes;

namespace XUnitTestZooApp
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(4, 2)]
        public void ReturnNemoCanSwim(int speed, int nemoSpeed)
        {
            // Arrange
            SouthPacific southPacific = new SouthPacific();
            southPacific.Speed = speed;

            // Act
            bool result = southPacific.CanNemoSwim(nemoSpeed);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ReturnReptilitaIsNotAThing()
        {
            // Arrange
            Reptilia reptilia = new Reptilia();

            // Act
            bool result = reptilia.IsAThing();

            // Assert
            Assert.False(result);
        }
    }
}
