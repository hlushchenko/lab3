using System;
namespace lab3
{
    class Token
    {
        private int _priority;
        private bool _isOperator;
        private float _value;

        public Token(string value)
        {
            if (float.TryParse(value, out _value))
            {
                _isOperator = false;
            }
            else
            {
                _priority = SetPriority(value);
            }

        }

        private int SetPriority(string a)
        {
            switch (Convert.ToChar(a))
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
                case '(':
                    return 0;
                case ')':
                    return 0;
                default:
                    return 0;
            }
        }

    }
}
