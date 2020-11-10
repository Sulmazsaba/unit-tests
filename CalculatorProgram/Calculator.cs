﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorProgram
{
  public  class Calculator
  {

     public  decimal Current { get; private set; }

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

        public decimal Multiply(params decimal[] numbers)
        {
            if (!numbers.Any())
                return Current;

            //Current = (Current == 0) ? numbers[0] : Current;
            var calculatedResult = 1.0M;
            foreach (var number in numbers)
            {
                calculatedResult *= number;
            }

            return calculatedResult;
        }
        public decimal Divide(params decimal[] numbers)
        {
            decimal result=numbers[0];
            for (int i = 1; i <= numbers.Length-1; i++)
            {
                result /= numbers[i];
            }

            return result;
        }
  }
}
