namespace JavaScript.Html.DOM.CSS
{
    public abstract class BackgroundAttachment
    {
        public static implicit operator BackgroundAttachment(string val)
        {
            return null;
        }

        /// <summary>
        /// The background image will scroll with the rest of the page. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Scroll = "scroll";

        /// <summary>
        /// The background image stays fixed
        /// </summary>
        [EvalAtCompile]
        public const string Fixed = "fixed";

        /// <summary>
        /// The setting of the background-attachment property is inherited from the parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";
    }
}
