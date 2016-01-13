using System;

namespace JavaScript.Html.DOM
{
    public class InputType
    {
        public static implicit operator InputType(string val)
        {
            return new InputType();
        }

        [EvalAtCompile]
        public const string Text = "text";

        [EvalAtCompile]
        public const string Password = "password";

        [EvalAtCompile]
        public const string Date = "date";

        [EvalAtCompile]
        public const string Radio = "radio";

        [EvalAtCompile]
        public const string CheckBox = "checkbox";
    }

    //TODO:More input object - radio checkbox etc.
    [RenameClass("Input")]
    public class InputText : HtmlElement
    {
        /// <summary>
        /// Sets or returns the default value of a text field
        /// </summary>
        public string DefaultValue;


        /// <summary>
        /// Sets or returns the maximum number of characters allowed in a text field
        /// </summary>
        public uint MaxLength;


        /// <summary>
        /// Sets or returns the value of the name attribute of a text field
        /// </summary>
        public string Name;


        /// <summary>
        /// Sets or returns whether a text field is read-only, or not
        /// </summary>
        public bool ReadOnly;


        /// <summary>
        /// Sets or returns the width of a text field (in number of characters)
        /// </summary>
        public uint Size;


        /// <summary>
        /// Returns which type of form element a text field is
        /// </summary>
        public InputType Type;


        /// <summary>
        /// Sets or returns the value of the value attribute of the text field
        /// </summary>
        public string Value;
    }
}
