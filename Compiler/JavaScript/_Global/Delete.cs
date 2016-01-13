namespace JavaScript
{
    [NonScript]
    [RenameClass("")]
    public static class Delete
    {
        /// <summary>
        /// Used to mimic delete operator in javascript, because C# don't have delete operator.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>        
        public static bool Del(System.Object property)
        {
            return false;
        }
    }
}
