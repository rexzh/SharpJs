namespace JavaScript
{
    [RenameClass("")]
    public static class Global
    {
        public const double Infinity = 0;
        public const double NaN = 0;
        public const object undefined = null;

        public static string DecodeURI(string uri)
        {
            return null;
        }

        public static string DecodeURIComponent(string uri)
        {
            return null;
        }

        public static string EncodeURI(string uri)
        {
            return null;
        }

        public static string EncodeURIComponent(string uri)
        {
            return null;
        }

        public static string Escape(string str)
        {
            return null;
        }

        public static string UnEscape(string str)
        {
            return null;
        }

        public static object Eval(string script)
        {
            return null;
        }

        public static bool IsFinite(object val)
        {
            return false;
        }

        public static bool IsNaN(object val)
        {
            return false;
        }

        [RenameMember("Number")]
        public static double Number(object val)
        {
            return 0;
        }

        public static double ParseFloat(string str)
        {
            return 0;
        }

        public static int ParseInt(string str)
        {
            return 0;
        }

        public static int ParseInt(string str, int radix)
        {
            return 0;
        }

        //[RenameMember("String")]
        //public static String String(object val)
        //{
        //    return null;
        //}
    }
}
