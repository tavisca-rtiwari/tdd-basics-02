using Operation;
namespace ConsoleCalculator
{
    public class Calculator
    {
        public static string output = null, tempOutput = null;
        public static char operator1 = '%', operator2 = '%';
        public static double operand1 = 0, operand2 = 0;
        public string SendKeyPress(char key)
        { 
            ICheck obj = new Check();
            
            if (obj != null)
            {
                return obj.Calculate(key);
            }
            if (output != null)
            {
                return output;
            }
            return "0";
        }

    }
}
