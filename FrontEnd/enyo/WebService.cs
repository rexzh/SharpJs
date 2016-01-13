using JavaScript;

namespace enyo
{
    public class WebService : _AjaxComponent
    {
        /// <summary>
        /// Set true to use JSONP protocol.
        /// </summary>
        public bool Jsonp { get; set; }

        /// <summary>
        /// When using JSONP, the name of the callback parameter. Note: this not the name of a callback function, but only the name of the callback parameter. Enyo will create an internal callback function as necessary.
        /// </summary>
        public string Callback { get; set; }

        /// <summary>
        /// When using JSONP, optional character set to use to interpret the return data
        /// </summary>
        public string Charset { get; set; }

        public Ajax Send(object param) { return null; }
        
        public EnyoEventHandler<Component, WebServiceEventArgs> OnError;
        public EnyoEventHandler<Component, WebServiceEventArgs> OnResponse;
    }
    
    [NoCompile]
    public sealed class WebServiceEventArgs : EnyoEventArgs
    {
        public object Data;
        public Ajax Ajax;
    }
}
