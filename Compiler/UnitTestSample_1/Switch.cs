using JavaScript;

namespace UnitTestSample_1
{
    public class Switch
    {
        public int Test(int x)
        {          
            int r = 0;
            switch (x)
            {
                case 0:
                    x++;
                    break;

                case 1:
                    x += 2;
                    break;

                case 2:
                    x--;
                    return -1;

                case 3:
                    throw new Error();

                case 4:
                    r = 100;
                    break;

                default:
                    x *= 2;
                    break;
            }
            return r;
        }
    }
}
