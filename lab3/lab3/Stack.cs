using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Drawing;

namespace lab3
{
    public class Stack<T>
    {
        private int _size;
        private int _length = 0;
        private T[] _stack;
        public int Length => _length;
        public int Size
        {
            get => _size;
            set
            {
                if (value <= 0)
                {
                    _stack = new T[0];
                }
                else
                {
                    T[] newStack = new T[value];
                    Array.Copy(_stack, newStack, _size);
                    _stack = newStack;
                    _size = value;
                }
            }
        }
        public Stack(int size = 0)
        {
            _size = size;
            _stack = new T[size];
        }
        public void Push(T item)
        {
            if (_length >= Size)
            {
                Size = _length + 1;
            }
            _stack[_length++] = item;
        }
        public T Back()
        {
            return _stack[_length--];
        }
    }
}