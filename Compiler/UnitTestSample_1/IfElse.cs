using System;

namespace UnitTestSample_1
{
    public class IfElse
    {
        public int Test(int x)
        {
            if (x < 0)
                return -1;
            else if (x > 0)
                return 1;
            return 0;
        }

        public bool StringTest(string s)
        {
            if (s != null)
                return false;
            else
                return true;
        }

        public bool HasData(int x)
        {
            if(x == 0)
                return false;
            return true;
        }
    }
}
