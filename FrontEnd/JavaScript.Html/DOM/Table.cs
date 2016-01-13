using System;

namespace JavaScript.Html.DOM
{
    [RenameClass("Table")]
    public class Table : HtmlElement
    {
        public Tr[] Rows;

        public void DeleteRow(uint index)
        {
        }

        public Tr InsertRow(uint index)
        {
            return null;
        }
    }
}
