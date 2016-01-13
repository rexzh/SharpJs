using JavaScript;

namespace onyx
{
    /// <summary>
    /// A control that provides input styling. Any controls inside the InputDecorator will appear to be inside an area styled as an input. Usually, an InputDecorator surrounds an onyx.Input; and, it's possible to place other controls like buttons to the right or left of the input control.
    /// </summary>
    public class InputDecorator : enyo.ToolDecorator
    {
        public bool AlwaysLooksFocused { get; set; }
    }
}
