using System;
using System.Reflection.Metadata;
using Xunit;

namespace CalculatorProgram.UnitTests
{
    public class UnitTest1 
    {

        [Fact]
        public void Test_AddTwoElements()
        {
            //Arrange 
            Calculator calculator=new Calculator();

            //Act
            var result = calculator.Sum(1,1);

            //Assert
            Assert.Equal(2,result);
        }

        [Fact]
        public void Test_AddManyElements()
        {
            //Arrange
            Calculator calculator=new Calculator();
            
            //Action
            var result = calculator.Sum(0.5M, 3, 2, 1, -3, 6.5M);

            //Assert
            Assert.Equal(10, result);
            //Assert.IsNotType<Decimal>(result);
        }

    }
}
