using System;

namespace UnitTestSample_1
{
    class Lambda
    {
        public void M1()
        {
            Func<int, bool> func = (x) =>
            {
                return x > 0;
            };
        }

        public void M2()
        {
            Func<int, bool> func = (x) => x > 0;
        }

        public void M3()
        {
            Func<int, bool> func = x => x > 0;
        }

        public void M4()
        {
            Action<int> func = x => x++;
        }

        public void M5()
        {
            Action<int, int> func = (x, y) => { x++; y++; };
        }

        public void D1()
        {
            Action<int> f = delegate(int x)
            {
                x++;
            };
        }

        public void D2()
        {
            Func<int, int> f = delegate(int x)
            {
                return x + 1;
            };
        }

        private void _X<T>(Action<T> func)
        {
        }

        public void Test1()
        {
            _X<int>(x => x++);
        }

        public void Test2()
        {
            this._X<int>(x => {
                x++;
                x = 0;
            });
        }

        public void Test3()
        {
            _X((int x) => x++);
        }

        public void Test4()
        {
            _X((int x) => {
                x++;
            });
        }
    }
}
