using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }




        private Random _random;   // here we are storing the random value 
        public Dart(Random random) // create a constractor that passes in a System.Random instance 
        {
            _random = random;
        }
        
        public void Throw()
        {
            Score = _random.Next(0, 21); // here we are setting up the random to go from 0 - 20 by setting the maxValue of the _random.Next to 21

            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;

        }

    }
}
