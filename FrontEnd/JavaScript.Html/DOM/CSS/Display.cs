using System;

namespace JavaScript.Html.DOM.CSS
{
    public abstract class Display
    {
        public static implicit operator Display(string val)
        {
            return null;
        }

        /// <summary>
        /// Element is rendered as a block-level element
        /// </summary>
        [EvalAtCompile]
        public const string Block = "block";


        /// <summary>
        /// Element is rendered as a block-level or inline element. Depends on context
        /// </summary>
        [EvalAtCompile]
        public const string Compact = "compact";


        /// <summary>
        /// The value of the display property is inherited from parent element
        /// </summary>
        [EvalAtCompile]
        public const string Inherit = "inherit";


        /// <summary>
        /// Element is rendered as an inline element. This is default
        /// </summary>
        [EvalAtCompile]
        public const string Inline = "inline";


        /// <summary>
        /// Element is rendered as a block box inside an inline box
        /// </summary>
        [EvalAtCompile]
        public const string InlineBlock = "inline-block";


        /// <summary>
        /// Element is rendered as an inline table (like <table>), with no line break before or after the table
        /// </summary>
        [EvalAtCompile]
        public const string InlineTable = "inline-table";


        /// <summary>
        /// Element is rendered as a list
        /// </summary>
        [EvalAtCompile]
        public const string ListItem = "list-item";


        /// <summary>
        /// This value sets content before or after a box to be a marker (used with :before and :after pseudo-elements. Otherwise this value is identical to "inline")
        /// </summary>
        [EvalAtCompile]
        public const string Marker = "marker";


        /// <summary>
        /// Element will not be displayed
        /// </summary>
        [EvalAtCompile]
        public const string None = "none";


        /// <summary>
        /// Element is rendered as block-level or inline element. Depends on context
        /// </summary>
        [EvalAtCompile]
        public const string RunIn = "run-in";


        /// <summary>
        /// Element is rendered as a block table (like <table>), with a line break before and after the table
        /// </summary>
        [EvalAtCompile]
        public const string Table = "table";


        /// <summary>
        /// Element is rendered as a table caption (like <caption>)
        /// </summary>
        [EvalAtCompile]
        public const string TableCaption = "table-caption";


        /// <summary>
        /// Element is rendered as a table cell (like <td> and <th>)
        /// </summary>
        [EvalAtCompile]
        public const string TableCell = "table-cell";


        /// <summary>
        /// Element is rendered as a column of cells (like <col>)
        /// </summary>
        [EvalAtCompile]
        public const string TableColumn = "table-column";


        /// <summary>
        /// Element is rendered as a group of one or more columns (like <colgroup>)
        /// </summary>
        [EvalAtCompile]
        public const string TableColumnGroup = "table-column-group";


        /// <summary>
        /// Element is rendered as a table footer row (like <tfoot>)
        /// </summary>
        [EvalAtCompile]
        public const string TableFooterGroup = "table-footer-group";


        /// <summary>
        /// Element is rendered as a table header row (like <thead>)
        /// </summary>
        [EvalAtCompile]
        public const string TableHeaderGroup = "table-header-group";


        /// <summary>
        /// Element is rendered as a table row (like <tr>)
        /// </summary>
        [EvalAtCompile]
        public const string TableRow = "table-row";


        /// <summary>
        /// Element is rendered as a group of one or more rows (like <tbody>)
        /// </summary>
        [EvalAtCompile]
        public const string TableRowGroup = "table-row-group";
    }
}
