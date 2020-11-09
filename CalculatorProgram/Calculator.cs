using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
  public  class Calculator
  {

     public  Decimal Current { get; private set; }

      public Calculator()
      {
           Current = 0;
      }

        public decimal Sum(params decimal[] numbers)
        {
            var result = 0.0M;

            foreach (var number in numbers)
            {
                result += number;
            }

            Current += result;
            return result;
        }


        public void Reset()
        {
            Current = 0;
        }
    }
}
