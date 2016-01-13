namespace JavaScript.Html.DOM
{
    [RenameClass("document")]
    public abstract class Document : HtmlElement
    {
        public readonly static HtmlElement Body;

        public static HtmlElement GetElementById(string id)
        {
            return null;
        }

        public static T GetElementById<T>(string id) where T : HtmlElement
        {
            return null;
        }

        public static HtmlElement[] GetElementsByName(string name)
        {
            return null;
        }

        public static HtmlElement[] GetElementsByTagName(string tagName)
        {
            return null;
        }

        public static HtmlElement QuerySelector(string selector)
        {
            return null;
        }

        public static T QuerySelector<T>(string selector) where T : HtmlElement
        {
            return null;
        }

        public static HtmlElement[] QuerySelectorAll(string selector)
        {
            return null;
        }

        /// <summary>
        /// Executes a command on the current document, current selection, or the given range.
        /// </summary>
        /// <param name="cmd">command string</param>
        /// <param name="ui">
        /// <para>false: Default. Do not display a user interface. Must be combined with vValue, if the command requires a value.</para>
        /// <para>true: Display a user interface if the command supports one.</para>
        /// </param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool ExecCommand(string cmd, bool ui, object val)
        {
            return false;
        }

        /// <summary>
        /// Returns a Boolean value that indicates the current state of the command.
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static bool QueryCommandState(string cmd)
        {
            return false;
        }
    }
}
