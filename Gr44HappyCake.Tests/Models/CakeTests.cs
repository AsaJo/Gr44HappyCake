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
    }
}