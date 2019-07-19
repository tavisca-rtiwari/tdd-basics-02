﻿using Operation;
namespace ConsoleCalculator
{
    class Dot : ICheckKeys
    {
        public bool MatchKey(char key)
        {
            return Operations.IsDot(key);
        }

        public string SelectKeys(char key)
        {
            if (Calculator.output == null)
            {
                Calculator.output = "0.";
                return Calculator.output;
            }
            if (!Calculator.output.Contains("."))
            {
                Calculator.output = Calculator.output + ".";
                return Calculator.output;
            }
            Calculator.output = Calculator.output.TrimStart('0');
            if (Calculator.output[0] == '.')
            {
                Calculator.output = "0" + Calculator.output;
            }
            return Calculator.output;
        }
    }
}
