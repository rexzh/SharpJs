using JavaScript;
using JavaScript.Html.DOM;

namespace enyo
{
    public class Control : UiComponent
    {
        /// <summary>
        /// HTML tag name to use for control. If it's null, no tag is generated, only the contents are used.
        /// </summary>
        public string Tag { get; set; }

        public object Attributes { get; set; }

        public string Classes { get; set; }
        public string Style { get; set; }

        /// <summary>
        /// If false, HTML codes in content are escaped before rendering.
        /// </summary>
        public bool AllowHtml { get; set; }

        public string Content { get; set; }

        public bool IsContainer { get; set; }
        public bool Fit { get; set; }
        public bool CanGenerate { get; set; }
        public bool Showing { get; set; }
        public bool NoStretch;
        public string Src { get; set; }

        /// <summary>
        /// Adds CSS class name cls to the class attribute of this object.
        /// </summary>
        /// <param name="cls"></param>
        public void AddClass(string cls) { }

        public bool HasClass(string cls)
        {
            return false;
        }

        /// <summary>
        /// Removes substring cls from the class attribute of this object.
        /// </summary>
        /// <param name="cls">Must have no leading or trailing spaces.</param>
        public void RemoveClass(string cls)
        {
        }

        /// <summary>
        /// Appends the String value of addendum to the content of this Control.
        /// </summary>
        /// <param name="addendum"></param>
        public void AddContent(string addendum) { }

        /// <summary>
        /// Adds or removes substring cls from the class attribute of this object
        /// </summary>
        /// <param name="cls"></param>
        /// <param name="addOrRemove">true to add, false to remove</param>
        public void AddRemoveClass(string cls, bool addOrRemove) { }

        public void AddStyles(string cssText) { }

        /// <summary>
        /// Adds CSS styles to the set of styles assigned to this object.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="val">null will remove the style</param>
        public void ApplyStyle(string style, object val) { }

        public string GetComputedStyleValue(string style, object fallback)
        {
            return null;
        }

        public string ControlClasses;
        public string DefaultKind;

        /// <summary>
        /// Sets the value of an attribute on this object.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val">null to remove an attribute</param>
        public void SetAttribute(string name, object val) { }
        /// <summary>
        /// Gets the value of an attribute on this object.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetAttribute(string name) { return null; }

        public void DomStylesChanged() { }

        /// <summary>
        /// Renders this object into DOM, generating a DOM node if needed.
        /// </summary>
        /// <returns></returns>
        public new Control Render()
        {
            return this;
        }

        /// <summary>
        /// Override to perform tasks that require access to the DOM node.
        /// call this.inherited first.
        /// </summary>
        public virtual void Rendered()
        {
        }

        public void RenderInto(string id)
        {
        }

        /// <summary>
        /// Returns the DOM node representing the Control. If the control is not currently rendered, returns null.
        /// Once hasNode() is called, the returned value is made available in the node property of this control.
        /// </summary>
        /// <returns></returns>
        public HtmlElement HasNode()
        {
            return null;
        }

        public HtmlElement Node;

        public object GetNodeProperty(string name, object fallback)
        {
            return 0;
        }

        public void SetNodeProperty(string name, object val)
        {
        }

        /// <summary>
        /// Convenience function for getting the class attribute. The class attribute represents the CSS classes assigned to this object; it is a string that can contain multiple CSS classes separated by spaces.
        /// </summary>
        /// <returns></returns>
        public string GetClassAttribute() { return null; }

        /// <summary>
        /// Convenience function for setting the class attribute. The class attribute represents the CSS classes assigned to this object; it is a string that can contain multiple CSS classes separated by spaces.
        /// </summary>
        /// <param name="cls"></param>
        public void SetClassAttribute(string cls) { }

        /// <summary>
        /// Values returned are only valid if hasNode() is truthy.
        /// </summary>
        /// <returns></returns>
        public Rectangle GetBounds()
        {
            return null;
        }

        public void SetBounds(RectBound bound, string unit = null)
        {
        }

        /// <summary>
        /// Show the control, same as set Showing = true
        /// </summary>
        public void Show() { }

        /// <summary>
        /// Hide the control, same as set Showing = false
        /// </summary>
        public void Hide() { }

        public virtual void StyleChanged(string oldStyle)
        {
        }

        public Control Write()
        {
            return this;
        }
        
        /// <summary>
        /// You may prevent a control from being moved into the menu by setting this to true (the default is false).
        /// </summary>
        public bool Unmoveable;
        //Extend:Don't expose now
        //initStyles
        //setupBodyFitting
        //stylesToNode

        //public EnyoEventHandler<Control, EnyoEventArgs> onload;
        //public EnyoEventHandler<Control, EnyoEventArgs> onunload;
        //public EnyoEventHandler<Control, EnyoEventArgs> onmessage;
        //public EnyoEventHandler<Control, EnyoEventArgs> onselect;
        public EnyoEventHandler<Control, EnyoEventArgs> onmousedown;
        public EnyoEventHandler<Control, EnyoEventArgs> onmouseup;
        public EnyoEventHandler<Control, EnyoEventArgs> onmouseover;
        public EnyoEventHandler<Control, EnyoEventArgs> onmouseout;
        public EnyoEventHandler<Control, EnyoEventArgs> onmousemove;
        public EnyoEventHandler<Control, EnyoEventArgs> onclick;
        public EnyoEventHandler<Control, EnyoEventArgs> ondblclick;
        public EnyoEventHandler<Control, EnyoEventArgs> onchange;
        public EnyoEventHandler<Control, EnyoEventArgs> oninput;
        public EnyoEventHandler<Control, EnyoEventArgs> onkeydown;
        public EnyoEventHandler<Control, EnyoEventArgs> onkeyup;
        public EnyoEventHandler<Control, EnyoEventArgs> onkeypress;
        public EnyoEventHandler<Control, EnyoEventArgs> onresize;
        

        public EnyoEventHandler<Control, EnyoEventArgs> ondown;
        public EnyoEventHandler<Control, EnyoEventArgs> onup;
        public EnyoEventHandler<Control, EnyoEventArgs> ontap;
        public EnyoEventHandler<Control, EnyoEventArgs> onmove;
        public EnyoEventHandler<Control, EnyoEventArgs> onenter;
        public EnyoEventHandler<Control, EnyoEventArgs> onleave;
        public EnyoEventHandler<Control, EnyoEventArgs> onhold;
        public EnyoEventHandler<Control, EnyoEventArgs> onrelease;
        public EnyoEventHandler<Control, EnyoEventArgs> onholdpulse;
        public EnyoEventHandler<Control, EnyoEventArgs> onflick;
        public EnyoEventHandler<Control, EnyoEventArgs> ondragstart;
        public EnyoEventHandler<Control, EnyoEventArgs> ondrag;
        public EnyoEventHandler<Control, EnyoEventArgs> ondragfinish;
        public EnyoEventHandler<Control, EnyoEventArgs> ondrop;
        public EnyoEventHandler<Control, EnyoEventArgs> ondragover;
        public EnyoEventHandler<Control, EnyoEventArgs> ondragout;
    }
}
