using System.Collections.Generic;

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
                    for (int i = 0; i < _stack.Length; i++)
                    {
                        newStack[i] = _stack[i];
                    }
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
                Size =_length == 0? 2 : _length * 2 ;
            }
            _stack[_length++] = item;
        }
        public T Back()
        {
            return _stack[_length-1];
        }

        public T Pop()
        {
            return _stack[--_length];
        }
    }
}