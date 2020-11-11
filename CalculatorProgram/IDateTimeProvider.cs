using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
  public  interface IDateTimeProvider
  {
      DateTime GetNow();
  }
}
