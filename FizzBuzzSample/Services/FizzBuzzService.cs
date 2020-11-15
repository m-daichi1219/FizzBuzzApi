using FizzBuzzSample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzSample.Services {
    public class FizzBuzzService : IFizzBuzz {
        public string GetWord(int n) {
            if (n < 1) throw new ArgumentException($"{nameof(n)}は1以上としてください");
            if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
            if (n % 5 == 0) return "Buzz";
            if (n % 3 == 0) return "Fizz";
            return n.ToString();
        }
    }
}
