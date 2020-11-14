using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturn()
        {
            var val = controller.GetOne(1);

             Assert.Equal("Something else", val.Value);
        }

        [Fact]
        public void Test1()
        {
            Assert.True(1==1);
        }
    }
}
