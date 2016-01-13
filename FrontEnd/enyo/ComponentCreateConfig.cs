using JavaScript;

namespace enyo
{
    [NonScript]
    public class ComponentCreateConfig : JavaScript.Object
    {
        public string Name;
        public string Kind;
        public ComponentCreateConfig[] Components;
    }
}
