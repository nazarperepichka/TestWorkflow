using App1.Console;
using Xunit;

namespace App1.Tests
{
    public class SomeLogicTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldReturnValue(bool value)
        {
            var res = SomeLogic.GetValue(value);
            Assert.Equal(value, res);
        }
    }
}
