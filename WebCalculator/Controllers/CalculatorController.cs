using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorProgram;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(nameof(Sum))]
        public decimal Sum(decimal x,decimal y)
        {
            return new Calculator().Sum(x,y);
        }
    }
}
