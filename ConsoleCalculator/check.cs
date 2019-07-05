using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalculator
{
    class Check : ICheck
    {
        private readonly List<ICheckKeys> _calculate;
        public Check()
        {
            _calculate = new List<ICheckKeys>();
            _calculate.Add(new Number());
            _calculate.Add(new Toggle());
            _calculate.Add(new Clear());
            _calculate.Add(new Operator());
            _calculate.Add(new Dot());
            _calculate.Add(new Equal());
        }
        public string Calculate(char key)
        {
            return _calculate.First(r => r.MatchKey(key)).SelectKeys(key);
        }
    }
}
