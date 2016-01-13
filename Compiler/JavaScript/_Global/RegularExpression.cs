namespace JavaScript
{
    [RenameClass("RegExp")]
    public class RegularExpression
    {
        public RegularExpression(string pattern, string modifiers)
        {
        }

        public bool Global
        {
            get { return false; }
        }

        public bool IgnoreCase
        {
            get { return false; }
        }

        public int LastIndex
        {
            get { return 0; }
        }

        public bool Multiline
        {
            get { return false; }
        }

        public string Source
        {
            get { return null; }
        }

        /// <summary>
        /// Tests for a match in a string. Returns the first match
        /// </summary>
        /// <returns></returns>
        public string Exec(string toSearch)
        {
            return null;
        }

        public bool Test(string toSearch)
        {
            return false;
        }

        [RenameMember("$1")]
        public static string _1;
        [RenameMember("$2")]
        public static string _2;
        [RenameMember("$3")]
        public static string _3;
        [RenameMember("$4")]
        public static string _4;
        [RenameMember("$5")]
        public static string _5;
        [RenameMember("$6")]
        public static string _6;
        [RenameMember("$7")]
        public static string _7;
        [RenameMember("$8")]
        public static string _8;
    }
}
