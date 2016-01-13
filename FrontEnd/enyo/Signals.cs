using System;

namespace enyo
{
    /// <summary>
    /// Signals components are used to listen to global messages.
    /// <para>An object with a Signals component can listen to messages sent from anywhere but declaring handlers for them.</para>
    /// <para>DOM events that have no node targets are broadcast as signals. This events include Window events, like onload and onbeforeunload, and events that occur directly on document, like onkeypress if document has the focus.</para>
    /// </summary>
    public class Signals : Component
    {
        public static void Send(string msg, object payload)
        {
        }

        public string ondeviceready;
        public string onpause;
        public string onresume;
        public string ononline;
        public string onoffline;
        public string onackbutton;
        public string onbatterycritical;
        public string onbatterylow;
        public string onbatterystatus;
        public string onmenubutton;
        public string onsearchbutton;
        public string onstartcallbutton;
        public string onendcallbutton;
        public string onvolumedownbutton;
        public string onvolumeupbutton;
    }
}
