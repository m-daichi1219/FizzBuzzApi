using FizzBuzzSample.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzApi.Controllers {
    [Route("api/fizzbuzz")]
    [Produces("application/json")]
    [ApiController]
    public class FizzBuzzController : Controller {
        private readonly IFizzBuzz _fizzbuzz;

        public FizzBuzzController(IFizzBuzz fizzBuzz) => _fizzbuzz = fizzBuzz;

        [HttpGet]
        public IEnumerable<string> Get(int from, int to) {
            var count = to - from + 1;
            return Enumerable.Range(from, count).Select(n => _fizzbuzz.GetWord(n));
        }
    }
}
