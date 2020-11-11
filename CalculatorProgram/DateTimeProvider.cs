using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
   public class DateTimeProvider :IDateTimeProvider
    {
        public DateTime GetNow() =>DateTime.Now;
    }
}
