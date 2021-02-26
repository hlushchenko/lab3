namespace lab3
{
    public class Stack
    {
        private int _maxSize;
        private int _currentPos;
        private int[] stack;

        public Stack(int length = 1024)
        {
            _maxSize = length;
            _currentPos = 0;
            stack = new int[_maxSize];
        }

        public int MaxSize => _maxSize;
        public int CurrentPos => _currentPos;
        public int Back => stack[_currentPos];
        
        public void Push(int num)
        {
            stack[_currentPos++] = num;
        }

        public void Pop()
        {
            stack[_currentPos--] = 0;
        }

        public void Clear()
        {
            _maxSize = 0;
        }
    }
}
