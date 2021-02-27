﻿using System;
namespace lab3
{
    class Token
    {
        private int _priority;
        private bool _isOperator;
        private float _value;

        public float Value => _value;
        public int Priority => _priority;
        public bool IsOperator => _isOperator;

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

        public Token(float value)
        {
            _isOperator = false;
            _value = value;
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
        public Token Calculate(Token operand1, Token operand2)
        {
            if (_isOperator)
            {
                float value = 0;
                switch (_value)
                {
                    case 2:
                        value = operand1.Value + operand2.Value;
                        break;
                    case 3:
                        value = operand2.Value - operand1.Value;
                        break;
                    case 4:
                        value = operand1.Value * operand2.Value;
                        break;
                    case 5:
                        value = operand1.Value * operand2.Value;
                        break;
                }
                return new Token(value);
            }
            return operand1;
        }
    }
}

