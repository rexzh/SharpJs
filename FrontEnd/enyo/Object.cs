using JavaScript;

namespace enyo
{
    public class Object : JavaScript.Object, IDataModel
    {
        public void Log(params object[] args) { }

        public void Warn(params object[] args) { }
        public void Error(params object[] args) { }

        public object Get(string name) { return null; }
        public void Set(string name, object val, bool force = false) { }

        /// <summary>
        /// Set this[name] to null, if this[name] is destroy-able, call destroy first.
        /// </summary>
        /// <param name="name"></param>
        public void DestroyObject(string name) { }

        protected void Inherited(Arguments arg)
        {
        }

        public object Published;

        public object Computed;
    }
}
