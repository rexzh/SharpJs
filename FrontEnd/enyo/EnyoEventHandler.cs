using System;

namespace enyo
{
    /// <summary>
    /// Event handler, signature is bool handler(sender, args) {}
    /// When declare in enyo style syntax, can convert from string(method name)
    /// </summary>
    /// <typeparam name="TSender"></typeparam>
    /// <typeparam name="TEventArg"></typeparam>
    //public delegate void EnyoEventHandler<S, A>(S sender, A eventArg);
    public class EnyoEventHandler<TSender, TEventArg>
    {
        private EnyoEventHandler() { }

        public static implicit operator EnyoEventHandler<TSender, TEventArg>(string method)
        {
            return null;
        }
    }
}
