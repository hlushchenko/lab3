using System;

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
                else
                {
                    operators.Push(token);
                }
            }
            return 0f;
        }

        private static Token[] StringToToken(string input)
        {
            input = $"( {input} )";
            string[] tokenStrings = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Token[] tokens = new Token[tokenStrings.Length];
            for (int i = 0; i < tokenStrings.Length; i++)
            {
                tokens[i] = new Token(tokenStrings[i]);
            }

            return tokens;
        }
    }
}