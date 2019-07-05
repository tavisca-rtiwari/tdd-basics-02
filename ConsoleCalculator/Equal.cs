using Data;
using Operation;
namespace ConsoleCalculator
{
    class Equal : ICheckKeys
    {
        public bool MatchKey(char key)
        {
            return Operations.IsEqual(key);
        }

        public string SelectKeys(char key)
        {
            DataOpertion dataOpertion = new DataOpertion();
            dataOpertion.GetTotal();
            Calculator.operator1 = '%';
            if (Calculator.output != null)
            {
                Calculator.tempOutput = Calculator.output;
                Calculator.output = null;
            }
            return Calculator.tempOutput;

        }
    }
}
