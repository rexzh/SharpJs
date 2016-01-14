using System;

namespace UnitTestSample_1
{
    class NormalClass3
    {
        private int _counter;
        public void IncreaseBy(int x)
        {
            _counter += x;
        }

        public void Increase()
        {
            _counter++;
        }

        public void Reset()
        {
            _counter = 0;
        }
    }
}
