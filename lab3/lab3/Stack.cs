namespace lab3
{
    public class Stack<T>
    {
        private int _size;
        private int _length = 0;
        private T[] stack;

        public Stack(int size = 1024)
        {
            _size = size;
            stack = new T[_size];
        }

        public int Size => _size;
        public int Length => _length;
        public T Back => stack[_length];

        public void Push(T num)
        {
            stack[_length++] = num;
        }

        public T Pop()
        {
            return stack[--_length];
        }
        
        
        public void Clear()
        {
            _size = 0;
        }
    }
}
