using System;

namespace UnitTestSample_1
{
    public class Operators
    {
        public void Unary()
        {
            int x = 0;
            var y = -x;
            var z = +x;

            var u = x++;
            var v = ++x;
            --x;
            x--;

            
            var a = ~x;
        }

        public void Binary()
        {
            int x = 0, y = 5;
            var z = x + y;
            var u = x - y;
            var w = x * y;
            var v = x / y;
            var m = x % y;

            z += 5;
            z *= 5;
            z -= 5;
            z /= 5;
            z %= 5;
        }

        public void Bit()
        {
            int x = 0, y = 1, z = 5;
            z = x >> 1;
            z = y << 1;   

            int a = 0, b = 0;
            int c = a & b;
            c = a | b;
            c = a ^ b;
            b = ~a;

            a ^= b;
        }

        public void Logic()
        {
            bool b1 = true, b2 = false;
            var b = b1 && b2;
            b = b1 || b2;
            b = b1 ^ b2;
            b = !b1;

            int x = 0, y = 10;
            b = x > y;
            b = x >= y;
            b = x < y;
            b = x <= y;
            b = x == y;
            b = x != y;
        }

        public void Other()
        {
            int? x = 10;
            var y = x ?? 0;

            var z = (x != null) ? x : y;
        }
    }
}
