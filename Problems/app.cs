using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal static class app
    {
        public static MathExpresion Run(string input)
        {
            var mathExpresion = new MathExpresion();
            input = input.Trim();
            var opertions = "+-*/%^";
            var token = "";
            bool leftSideIntialized = false;
            for (int i = 0; i < input.Length; i++)
            {
                var currentLetter = input[i];

                if (char.IsDigit(currentLetter))
                {
                    token += currentLetter;
                }
                else if (char.IsLetter(currentLetter))
                {
                    if(i == 0)
                    {
                        mathExpresion.LeftSideOperent = 1;
                        leftSideIntialized = true;  
                    }
                    token += currentLetter;
                }
                else if (opertions.Contains(currentLetter))
                {
                    if (!string.IsNullOrEmpty(token))
                    {
                        mathExpresion.LeftSideOperent = double.Parse(token);
                        leftSideIntialized = true;
                        token = "";
                    }
                    else if (currentLetter == '-')
                    {
                        token += currentLetter;
                    }
                    mathExpresion.operation = Parse(currentLetter.ToString());
                }
                else if (char.IsWhiteSpace(currentLetter) && !string.IsNullOrEmpty(token))
                {
                    if (leftSideIntialized)
                    {
                        mathExpresion.operation = Parse(token.ToLower());
                        token = "";
                    }
                    else
                    {
                        mathExpresion.LeftSideOperent = double.Parse(token);
                        leftSideIntialized = true;
                        token = "";
                    }
                }
                if (i == input.Length - 1)
                {
                    mathExpresion.RightSideOperent = double.Parse(token);
                    token = "";
                }
            }
            return mathExpresion;
        }

        static Operation Parse(string currentLetter)
        {
            switch (currentLetter)
            {
                case "+":
                case "add":
                case "addition":
                    return Operation.Addition;
                case "-":
                case "sub":
                case "subtraction":
                    return Operation.Subtraction;
                case "*":
                case "multiplication":
                    return Operation.Multiplication;
                case "/":
                case "division":
                case "div":
                    return Operation.Division;
                case "^":
                case "pow":
                case "power":
                    return Operation.Power;
                case "%":
                case "mod":
                case "modulus":
                    return Operation.Modulus;
                case "sin":
                    return Operation.Sin;
                case "cos":
                    return Operation.Cos;
                case "tan":
                    return Operation.Tan;
                default:
                    return Operation.None;
            }
        }
    }
}
