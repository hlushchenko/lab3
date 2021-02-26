namespace lab3
{
    public class Stack
    {
        private int _maxLength;
        private int _currentPos;
        private int[] stack;

        public Stack(int length = 1024)
        {
            _maxLength = length;
            _currentPos = 0;
            stack = new int[_maxLength];
        }

        public int MaxSize => _maxLength;
        public int CurrentPos => _currentPos;
        public int Back => stack[_currentPos];

        public void Push(int num)
        {
            stack[_currentPos++] = num;
        }

        public int Pop()
        {
            return stack[_currentPos - 1];
        }

        public void Clear()
        {
            _maxLength = 0;
        }
    }
}
