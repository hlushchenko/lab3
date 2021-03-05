using System.ComponentModel.DataAnnotations;

namespace lab3
{
    public class Stack<T>
    {
        private int _size;
        private int _length = 0;
        private T[] _stack;

        public int Length
        {
            get => _length;
            set => _length = value;
        }

        public Stack(int size = 0)
        {
            _size = size;
            _stack = new T[size];
        }

        public void Push(T item)
        {
            if (/*_length < _size*/ true)
            {
                _stack[_length++] = item;
            }
        }
    }
}
