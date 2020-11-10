using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorProgram.UnitTests
{
   public class MultiplyDivideTest
   {
        [Fact]
        public void Test_MultiplyTwoElements()
        {
            //Arrange
            var calculator=new Calculator();

            //Act
            var result = calculator.Multiply(10, 2);
            
            //Assert
            Assert.Equal(20,result);
        }


        [Fact]
        public void Test_MultiplyManyElements()
        {
            //Arrange
            var calculator=new Calculator();

            //Act
            var result = calculator.Multiply(6, 3, 2, -0.5M);

            //Assert
            Assert.Equal(-18,result);
            Assert.IsType<decimal>(result);
        }


        [Fact]
        public void Test_DivideTwoElements()
        {
            //arrange 
            var calculator=new Calculator();

            //Act
            var result = calculator.Divide(10, 2);

            //Assert
            Assert.Equal(5,result);
        }

        [Fact]
        public void Test_DivideManyElements()
        {
            // Arrange
            var calculator=new Calculator();

            //Act
            var result = calculator.Divide(100, 4, 5, 2.5M);

            //Assert
            Assert.Equal((decimal)2,result);
            Assert.IsType<decimal>(result);

        }

   }
}
