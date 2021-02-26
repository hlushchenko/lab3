namespace lab3
{
    public class Stack<T>
    {
        private int _maxLength;
        private int _currentPos;
        private T[] stack;

        public Stack(int length = 1024)
        {
            _maxLength = length;
            _currentPos = 0;
            stack = new T[_maxLength];
        }

        public int MaxSize => _maxLength;
        public int CurrentPos => _currentPos;
        public T Back => stack[_currentPos];

        public void Push(T num)
        {
            stack[_currentPos++] = num;
        }

        public T Pop()
        {
            return stack[_currentPos - 1];
        }

        public void Clear()
        {
            _maxLength = 0;
        }
    }
}
