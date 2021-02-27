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
                _isOperator = true;
                _value = SetValue(value);
                _priority = Convert.ToInt32(_value) / 2;
            }

        }

        private int SetValue(string a)
        {
            switch (a[0])
            {
                case '(':
                    return 0;
                case ')':
                    return 1;
                case '+':
                    return 2;
                case '-':
                    return 3;
                case '*':
                    return 4;
                case '/':
                    return 5;
                default:
                    return 0;
            }
        }

    }
}
