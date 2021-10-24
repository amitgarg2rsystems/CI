using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    
    
    public class UnitTest1
    {
        WeatherForecastController obj;
        [Fact]
        public void Test1()
        {
            obj =new WeatherForecastController();
            var objGet= obj.Get(1);
            Assert.Equal("Amit Garg",objGet.Value);

        }
    }
}
