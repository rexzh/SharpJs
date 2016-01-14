using JavaScript;

namespace UnitTestSample_1
{
    [RenameClass("sp.main")]
    public class SpecialName
    {
        [RenameMember("n")]
        public string s;

        [RenameMember("func")]
        public void Test()
        {
            var d = new { x = 5 };

            s = "x";
        }
    }
}
