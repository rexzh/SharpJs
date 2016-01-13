namespace JavaScript
{
    [ScriptDefaultValue(Value = "false")]
    [RenameClass("Boolean")]
    public class Boolean : Object
    {
        public static implicit operator Boolean(bool b)
        {
            return null;
        }

        public static explicit operator bool (Boolean b)
        {
            return false;
        }

        /*
        public Array ValueOf()
        {
            return null;
        }
        */
    }
}
