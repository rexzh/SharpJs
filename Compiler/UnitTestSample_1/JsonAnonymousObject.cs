using JavaScript;

namespace UnitTestSample_1
{
    class JsonAnonymousObject
    {
        public void Upper()
        {
            var p = new { X = 0, Y = 1 };
        }

        public void Lower()
        {
            var p = new { x = 0, y = 1 };
        }
    }
}
