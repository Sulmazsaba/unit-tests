using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorProgram.UnitTests
{
  public  class CalculatorMemoryTests :IDisposable
  {
      private Calculator calculator;
        public CalculatorMemoryTests()
        {
            calculator=new Calculator();
        }

        [Fact]
        public void AddNumberTest()
        {
            calculator.Reset();

            calculator.Sum(2);
            calculator.Sum(3);

            Assert.Equal(5,calculator.Current);
        }

        public void Dispose()
        {
            calculator.Reset();
        }
    }
}
