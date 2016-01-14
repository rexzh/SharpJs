using System;

namespace UnitTestSample_1
{
    public class NormalClass1
    {
        private int _x = 0;
        public void Reset() => _x = 0;

        public int Add(int y) => _x + y;
    }
}
