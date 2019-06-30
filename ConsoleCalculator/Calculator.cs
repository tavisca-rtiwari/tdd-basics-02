using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        private string output = null,tempOutput=null;
        private char operator1 = 'z',operator2='z';
        private double operand1 = 0, operand2 = 0;
        public string SendKeyPress(char key)
        {
            int keyValue = (int)key;
            if (IsNumber(keyValue))
            {
                if (IsOperator((int)operator2))
                {
                    operator2 = 'z';
                    output = null;
                    output = output + key.ToString();

                }
                else
                {
                    output = output + key.ToString();
                }
                return output;
            }
            else if (IsOperator(keyValue))
            {
                if (IsOperator((int)operator1))
                {
                    GetTotal();
                    operator2 = key;
                    operator1 = key;
                    operand1 = double.Parse(output);
                    return output;
                }
                else
                {   if (output == null)
                    {
                        operator1 = 'z';
                        operand1 = 0;
                        operand2 = 0;
                        output = null;
                        return "0";
                    }
                    else
                    {
                        operand1 = double.Parse(output);
                        operator1 = key;
                        operator2 = key;
                    }
                }
                return output;
            
            }
            else if (IsEqual(keyValue))
            {
                GetTotal();
                operator1 = 'z';
                if (output != null)
                {
                    tempOutput = output;
                    output = null;
                }
                return tempOutput;

            }
            else if (IsClear(keyValue))
            {
                operator1 = 'z';
                operand1 = 0;
                operand2 = 0;
                output = null;
                return "0";
            }
            else if (IsToggle(key))
            {
                if (output.Equals("0"))
                {
                    return "0";
                }
                else
                {
                    operand2 = -1 * Convert.ToDouble(output);
                    output = operand2.ToString();
                    return output;
                }
            }
            else if (key == 46)
            {
                if (output == null) output = ".";
                if ( !output.Contains("."))
                {
                    output = output + ".";
                }
                output = output.TrimStart('0');
                if (output[0] == '.')
                {
                    output = "0" + output;
                }
                if (output == null)
                {
                    output = "0.";
                }
                return output;
            }
            return "0";
        }

        private static bool IsToggle(char key)
        {
            return key == 83 || key == 115;
        }

        private void GetTotal()
        {
            if (output != null)
            {
                operand2 = double.Parse(output);
            }
            switch (operator1)
            {
                case '-':
                    output = Subtract(operand1, operand2);
                    operand2 = 0;
                    break;
                case '+':
                    output = Add(operand1, operand2);
                    operand2 = 0;
                    break;
                case '/':
                    output = Division(operand1, operand2);
                    operand2 = 0;
                    break;
                case 'x':
                case 'X':
                    output = Multiply(operand1, operand2);
                    operand2 = 0;
                    break;
            }
        }

        private static bool IsClear(int keyValue)
        {
            return keyValue == 'c' || keyValue == 'C';
        }

        private string Multiply(double operand1, double operand2)
        {
            return (operand1 * operand2).ToString();
            // throw new NotImplementedException();
        }

        private string Division(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                return "-E-";
            }
            else
            {
               return (operand1 / operand2).ToString();
            }
            //throw new NotImplementedException();
        }

        private string Subtract(double operand1, double operand2)
        {
            return (operand1 - operand2).ToString();
            //throw new NotImplementedException();
        }

        private string Add(double operand1, double operand2)
        {
            return (operand1 + operand2).ToString();
           // throw new NotImplementedException();
        }

        private static bool IsEqual(int keyValue)
        {
            return keyValue == 61;
        }

        private static bool IsOperator(int keyValue)
        {
            return keyValue == 45 || keyValue == 43 || keyValue == 47 || keyValue == 88 || keyValue == 120;
        }

        private static bool IsNumber(int keyValue)
        {
            return keyValue >= 48 && keyValue <= 57;
        }
    }
}
