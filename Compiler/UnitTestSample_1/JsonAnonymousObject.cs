using JavaScript;

namespace UnitTestSample_1
{
    class JsonAnonymousObject
    {
        public void NoQuote()
        {
            var p = new { x = 0, y = 1 };
        }

        public void HasQuote()
        {
            var p = new { x = 0, y = 1 };
        }

        public void FollowClass()
        {
            var p = new { x = 0, y = 1 };
        }
    }
}
