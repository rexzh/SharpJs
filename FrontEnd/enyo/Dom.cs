using JavaScript;
using JavaScript.Html.DOM;

namespace enyo
{
    [NonScript]
    public class Dom
    {
        /// <summary>
        /// Shortcut for document.getElementById if id is a string, otherwise returns id. Uses window.document unless a document is specified in the (optional) doc parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public HtmlElement ById(string id, Document doc = null) 
        {
            return null;
        }

        public string Escape(string text) { return null; }
    }
}
