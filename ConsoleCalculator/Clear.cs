using Operation;
namespace ConsoleCalculator
{
    class Clear : ICheckKeys
    {
        public bool MatchKey(char key)
        {
            return Operations.IsClear(key);
        }

        public string SelectKeys(char key)
        {
            Calculator.operator1 = '%';
            Calculator.operand1 = 0;
            Calculator.operand2 = 0;
            Calculator.output = null;
            return "0";
        }
    }
}
