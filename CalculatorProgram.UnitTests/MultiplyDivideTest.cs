using System;
using System.Collections.Generic;
using System.Text;
using Moq;
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

        [Fact]
        public void Test_DivideByZero()
        {
            //arrange
            var calculator=new Calculator();

            Assert.Throws<System.DivideByZeroException>(() =>
            {

                //act
                var result = calculator.Divide(1, 0);

                //assert
                Assert.IsType<decimal>(result);
            });

        }

        [Fact]
        public void Test_Validation()
        {
            // arrange
            var calculator=new Calculator();

            Assert.Throws<InvalidOperationException>(() =>
            {
                //act
                var result = calculator.Divide(decimal.MaxValue, decimal.MaxValue);

                //assert,Then
                Assert.IsType<decimal>(result);
            });
        }

        [Fact]
        public void Test_MaintenanceDateHit()
        {
            //Arrange
            var mockDateTime=new Moq.Mock<IDateTimeProvider>();
            mockDateTime.Setup(mock => mock.GetNow())
                .Returns(()=>new DateTime(2100,1,1,0,0,0));

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                var calculator=new Calculator(mockDateTime.Object);
            });


            //Assert
            Assert.True(exception.Message.Contains("Date Time Error"));
            mockDateTime.Verify(mock=>mock.GetNow(),Times.Once);

        }

   }
}
