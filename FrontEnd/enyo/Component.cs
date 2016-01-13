using JavaScript;

namespace enyo
{
    public class Component : enyo.Object
    {
        public Component()
        {
        }

        public Component(ComponentCreateConfig config)
        {
        }

        /// <summary>
        /// For enyo syntax.
        /// </summary>
        public ComponentKind Kind;

        public string Name { get; set; }
        public string Id { get; set; }
        public Component Owner { get; set; }

        /// <summary>
        /// The components hash '$', since it is invalid in c#, use '_' instead
        /// </summary>
        [RenameMember("$")]//TODO:??is there some other possible???
        public enyo.Object _;

        public Component[] Components;

        /// <summary>
        /// When override, remember call this.Inherited(Arguments.Value) to invoke base method.
        /// before this statement, all sub-components is not constructed.
        /// after this statement, all sub-components are ready, $(_) is ready.
        /// </summary>
        public virtual void Create()
        {
        }

        public void AddComponent(Component c) { }
        public void RemoveComponent(Component c) { }
        public Component[] GetComponents() { return null; }

        /// <summary>
        /// Bubbles an event up an object chain, starting with this.
        /// </summary>
        /// <param name="evtName"></param>
        /// <param name="evt"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool Bubble(string evtName, EnyoEventArgs evt, Component sender)
        {
            return false;
        }

        /// <summary>
        /// Bubbles an event up an object chain, starting above this.
        /// </summary>
        /// <param name="evtName"></param>
        /// <param name="evt"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool BubbleUp(string evtName, EnyoEventArgs evt, Component sender)
        {
            return false;
        }

        /// <summary>
        /// Create component with config mix with moreInfo, config override moreInfo
        /// </summary>
        /// <param name="config"></param>
        /// <param name="moreInfo"></param>
        /// <returns></returns>
        public Component CreateComponent(ComponentCreateConfig config, object moreInfo)
        {
            return null;
        }

        /// <summary>
        /// Create components with each config mix with moreInfo, config override moreCommonInfo
        /// </summary>
        /// <param name="config"></param>
        /// <param name="moreCommonInfo"></param>
        /// <returns></returns>
        public Component[] CreateComponents(ComponentCreateConfig[] config, object moreCommonInfo)
        {
            return null;
        }

        /// <summary>
        /// Removes this Component from its owner (sets owner to null) and does any cleanup.
        /// </summary>
        public void Destroy() { }

        /// <summary>
        /// Destroys all owned components.
        /// </summary>
        public void DestroyComponents() { }

        public virtual void OwnerChanged(Component oldOwner)
        {
        }

        public void Render()
        {
        }

        //Extend:Don't expose now
        //public bool DispatchBubble(string evtName, EnyoEvent evt, Component sender)
        //public string MakeId()
        //public void NameComponent()
        
    }
}
