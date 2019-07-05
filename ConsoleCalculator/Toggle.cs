using System;
using Operation;
namespace ConsoleCalculator
{
    class Toggle : ICheckKeys
    {
        public bool MatchKey(char key)
        {
            return Operations.IsToggle(key);
        }

        public string SelectKeys(char key)
        {
            if (Calculator.output.Equals("0"))
            {
                return "0";
            }

            Calculator.operand2 = -1 * Convert.ToDouble(Calculator.output);
            Calculator.output = Calculator.operand2.ToString();
            return Calculator.output;
        }
    }
}
