﻿using Data;
using Operation;

namespace ConsoleCalculator
{
    class Operator : ICheckKeys
    {
        public bool MatchKey(char key)
        {
            return Operations.IsOperator(key);
        }

        public string SelectKeys(char key)
        {
            DataOpertion dataOpertion = new DataOpertion();

            if (Operations.IsOperator(Calculator.operator1))
            {
                dataOpertion.GetTotal();
                Calculator.operator2 = key;
                Calculator.operator1 = key;
                Calculator.operand1 = double.Parse(Calculator.output);
                return Calculator.output;
            }
            if (Calculator.output == null)
            {
                Calculator.operator1 = '%';
                Calculator.operand1 = 0;
                Calculator.operand2 = 0;
                Calculator.output = null;
                return "0";
            }

            Calculator.operand1 = double.Parse(Calculator.output);
            Calculator.operator1 = key;
            Calculator.operator2 = key;
            Calculator.tempOutput = Calculator.output;
            Calculator.output = null;
            return Calculator.tempOutput;
        }
    }
}
