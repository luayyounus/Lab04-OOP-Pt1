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


    }
}
