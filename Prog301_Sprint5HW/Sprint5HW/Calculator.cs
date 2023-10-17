using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint5HW
{
    //Will take inputs and create an eqaution and produce a result
    public class Calculator
    {
        int result;
        public int Result { get => result; set => result = value; }
        

        string inputs;
        public string Inputs { get => inputs; set => inputs = value; }

        
        public char MathChar { get => mathChar; set => mathChar = value; }

        char mathChar;

        
        public string currentInput;

        public string currentNumber;


        public Calculator()
        {
            result = 0;
            inputs = "";
            currentInput = "";
            currentNumber = "";
        }

        void ResetCalc()
        {
            currentInput = "";
            currentNumber = "";
        }

        public void changeMathChar(char _mathChar)
        {
            mathChar = _mathChar;
        }

        public void inputNumber(string number)
        {
            currentNumber += number;
        }

        public int calculate()
        {
            int number = Convert.ToInt32(currentNumber);

            // Update the result
            // Addition
            if (mathChar == '+')
                result += number;

            //Subtraction
            else if (mathChar == '-')
                result -= number;
            
            //Multiplication
            else if (mathChar == '*')
                result *= number;
            
            //Division
            else if (mathChar == '/')
                result /= number;


            // Update the string inputs
            inputs += $"{mathChar} {number} ";

            ResetCalc();

            return result;
        }
    }
}
