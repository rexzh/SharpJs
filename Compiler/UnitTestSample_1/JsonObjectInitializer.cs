using JavaScript;

namespace UnitTestSample_1
{

    public class JsonObjectInitializer
    {
        public void FollowClass()
        {
            var p = new Point() { x = 0, y = 1 };
        }
    }

    [NoCompile]
    class Point
    {
        public int x;
        public int y;
    }
}
