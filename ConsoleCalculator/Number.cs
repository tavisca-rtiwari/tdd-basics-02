using Operation;

namespace ConsoleCalculator
{
    class Number : CheckKeys
    {
        public string SelectKeys(char key)
        {

            if (Operations.IsOperator(Calculator.operator2))
            {
                Calculator.operator2 = '%';
                Calculator.output = null;

            }
            Calculator.output = Calculator.output + key.ToString();
            return Calculator.output;
        }
    }
}
