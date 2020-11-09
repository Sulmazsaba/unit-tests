using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
  public  class Calculator
    {

        public decimal Sum(params decimal[] numbers)
        {
            var result = 0.0M;

            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}
