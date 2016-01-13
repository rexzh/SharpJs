using System;
using JavaScript;

namespace enyo
{
    public class Async : enyo.Object
    {
        /// <summary>
        /// If set to a non-zero value, the number of milliseconds to wait after the go call before failing with the "timeout" error
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Registers an error handler.
        /// </summary>
        /// <param name="handle">object function(sender, val) {}
        /// <para>sender is async object, if it return value other than null, the value is pass to next handler as val.</para>
        /// </param>
        /// <returns></returns>
        public Async Error(Func<Async, JavaScript.Object, JavaScript.Object> handle)
        {
            return null;
        }

        /// <summary>
        /// Registers an error handler.
        /// </summary>
        /// <param name="context">"this" context for the response method</param>
        /// <param name="handle">object function(sender, val) {}
        /// <para>sender is async object, if it return value other than null, the value is pass to next handler as val.</para>
        /// </param>
        /// <returns></returns>
        public Async Error(JavaScript.Object context, Func<Async, JavaScript.Object, JavaScript.Object> handle)
        {
            return null;
        }

        /// <summary>
        /// Registers a response handler.
        /// </summary>
        /// <param name="handle">object function(sender, val) {}
        /// <para>sender is async object, if it return value other than null, the value is pass to next handler as val.</para>
        /// </param>
        /// <returns></returns>
        public Async Response(Func<Async, JavaScript.Object, JavaScript.Object> handle)
        {
            return null;
        }

        /// <summary>
        /// Registers a response handler.
        /// </summary>
        /// <param name="context">"this" context for the response method</param>
        /// <param name="handle">object function(sender, val) {}
        /// <para>sender is async object, if it return value other than null, the value is pass to next handler as val.</para>
        /// </param>
        /// <returns></returns>
        public Async Response(JavaScript.Object context, Func<Async, JavaScript.Object, JavaScript.Object> handle)
        {
            return null;
        }

        /// <summary>
        /// //Can be called from any handler to trigger the error chain.
        /// </summary>
        /// <param name="val"></param>
        public void Fail(JavaScript.Object val)
        {
        }

        /// <summary>
        /// Called from an error handler, this method clears the error.
        /// </summary>
        public void Recover()
        {
        }

        /// <summary>
        /// Starts the async activity. Overridden in subkinds.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public virtual Async Go(System.Object val)
        {
            return this;
        }
    }
}
