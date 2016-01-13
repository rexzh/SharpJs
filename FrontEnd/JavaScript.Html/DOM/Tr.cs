using System;

namespace JavaScript.Html.DOM
{
    [RenameClass("Tr")]
    public class Tr : HtmlElement
    {
        public Td[] Cells;

        public void DeleteCell(uint index)
        {
        }

        public Td InsertCell(uint index)
        {
            return null;
        }
    }
}
