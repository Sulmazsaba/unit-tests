using Calculator.IntegrationTests;
using FluentAssertions;
using Xunit;

namespace WebCalculator.IntegrationTests
{
   public class WebCalculatorTests
    {
        [Fact]
        public async void Test_WebCalculatorSum()
        {
            //Arrange
            var context=new TestContext();

            //Act
            using (var client=context.Client)
            {
                var response = await client.GetAsync("/api/calculator/sum?x=4&y=9");
                //Assert.True(response.IsSuccessStatusCode);
                response.IsSuccessStatusCode.Should().Be(true);

                var content =await response.Content.ReadAsStringAsync();
                //Assert.Equal("36.0",content);
                content.Should().Be("13.0");
            }

        }
    }
}
