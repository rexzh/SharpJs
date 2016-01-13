using System;

namespace JavaScript.Html.DOM
{
    public class Canvas : HtmlElement
    {
        private Canvas() { }

        public T GetContext<T>(ContextType type) where T : Context
        {
            return null;
        }
    }
}
