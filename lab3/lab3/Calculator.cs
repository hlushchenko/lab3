using System;
using System.Linq;

namespace lab3
{
    public class Calculator
    {
        public static float Calculate(string input)
        {
            Token[] tokens = StringToToken(input);
            Stack<Token> operands = new Stack<Token>(16);
            Stack<Token> operators = new Stack<Token>(16);
            foreach (var token in tokens)
            {
                if (!token.IsOperator)
                {
                    operands.Push(token);
                }
                else if (token.Value == 1)
                {
                    while (operators.Back.Value != 0)
                    {
                        operands.Push(operators.Pop().Calculate(operands.Pop(), operands.Pop()));
                    }
                    operators.Pop();
                }
                else if (operators.Length == 0 || token.Value == 0)
                {
                    operators.Push(token);
                }
                else if (operators.Back.Priority <= token.Priority)
                { 
                    operators.Push(token);
                }
                else if (operators.Back.Priority > token.Priority)
                {
                    while (operators.Back.Priority > token.Priority || operators.Length != 1)
                    {
                        operands.Push(operators.Pop().Calculate(operands.Pop(), operands.Pop()));
                    }
                    operators.Push(token);
                }
            }
            return operands.Back.Value;
        }

        private static Token[] StringToToken(string input)
        {
            input = $"( {input} )";
            string[] tokenStrings = string.Join("", input.Select(a => char.IsDigit(a) ? $"{a}" : $" {a} ")).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Token[] tokens = new Token[tokenStrings.Length];
            for (int i = 0; i < tokenStrings.Length; i++)
            {
                tokens[i] = new Token(tokenStrings[i]);
            }
            return tokens;
        }
    }
}