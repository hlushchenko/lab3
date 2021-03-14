using System;
using System.Linq;

namespace lab3
{
    public class Calculator
    {
        public static float Calculate(string input)
        {
            Token[] tokens = StringToToken(input);
            Stack<Token> operands = new Stack<Token>();
            Stack<Token> operators = new Stack<Token>();
            foreach (var token in tokens)
            {
                if (!token.IsOperator)
                {
                    operands.Push(token);
                }
                else if (token.Value == 1)
                {
                    while (operators.Back().Value != 0)
                    {
                        operands.Push(operators.Pop().Calculate(operands.Pop(), operands.Pop()));
                    }
                    operators.Pop();
                }
                else if (operators.Length == 0 || token.Value == 0)
                {
                    operators.Push(token);
                }
                else if (operators.Back().Priority <= token.Priority)
                {
                    operators.Push(token);
                }
                else if (operators.Back().Priority > token.Priority)
                {
                    while (operators.Back().Priority > token.Priority && operators.Length != 1)
                    {
                        operands.Push(operators.Pop().Calculate(operands.Pop(), operands.Pop()));
                    }
                    operators.Push(token);
                }
            }
            while (operators.Length!=0)
            {
                operands.Push(operators.Pop().Calculate(operands.Pop(), operands.Pop()));
            }

            return operands.Back().Value;
        }

        private static Token[] StringToToken(string input)
        {
            FormatString(ref input);
            string[] tokenStrings = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Token[] tokens = new Token[tokenStrings.Length];
            for (int i = 0; i < tokenStrings.Length; i++)
            {
                tokens[i] = new Token(tokenStrings[i]);
            }
            return tokens;
        }

        public static void FormatString(ref string str)
        {
            str = string.Join("", str.Select(a => char.IsDigit(a) ? $"{a}" : $" {a} "));
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ".ToString());
            }
            str = str.Trim(' ');
            for (int i = 0; i < str.Length; i++)
            {
                //if ((i == 0 && char.IsDigit(str[i + 2])) || (i >= 2 && str[i] == '-' && !char.IsDigit(str[i-2]))) str = str.Remove(i+1, 1);
                if (i >= 2 && str[i] == '-' && !char.IsDigit(str[i - 2])) str = str.Remove(i + 1, 1);
            }
        }
    }
}