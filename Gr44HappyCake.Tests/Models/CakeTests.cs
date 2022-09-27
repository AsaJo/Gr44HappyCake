using Gr44HappyCake.Models;

namespace Gr44HappyCake.Tests.Models
{
    public class CakeTests
    {
        [Fact]
        public void BakedTheCakeGoodTempAndTimeTest()
        {
            // Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("strawberryJam", "cream", time, temp);// parts of the cake and it knows


            // Act
            bool cakeNotDone = testCake.BakedAndDone;
            bool result = testCake.BakeTheCake(temp,time);

            // Assert

            Assert.False(cakeNotDone);
            Assert.True(result);
            Assert.True(testCake.BakedAndDone);
        }
        [Fact]
        public void BurnTheCakeTest()
        {
            // Arrange

            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("AppleJam", "cream", time, temp);

            //Act
            bool cakeNotDone = testCake.BakedAndDone;
            Exception result = Assert.Throws<Exception>(() => testCake.BakeTheCake((temp *3),(time * 3)));

            //Assert
            Assert.False(cakeNotDone);
            Assert.Contains("burn", result.Message);
            Assert.False(testCake.BakedAndDone);


        }
        [Theory]
        [InlineData(1, 0.9)]// 1 == 100% | 0.9 == 90%
        [InlineData(0.9, 1)]
        [InlineData(0.9, 0.8)]
        public void BakeTheCakeBadTempTimeTest(double tempOffset, double timeOffset)
        {
            // Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("AppleJam", "cream", time, temp);

            // Act
            bool cakeNotDone = testCake.BakedAndDone; 
            bool result = testCake.BakeTheCake(temp * tempOffset, time * timeOffset);


            // Assert
            Assert.False(cakeNotDone);
            Assert.Equal(testCake.BakedAndDone, result);    
        }

    }
}