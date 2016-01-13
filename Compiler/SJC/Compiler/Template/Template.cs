using System;

using RexToy.Template;

namespace SJC.Compiler.Template
{
    abstract class AbstractTemplate
    {
        protected AbstractTemplate(string begin, string end)
        {
            _begin = begin;
            _end = end;
            _engine = TemplateEngine.CreateInstance();
        }

        protected string _begin;
        protected string _end;
        protected ITemplateEngine _engine;

        public string GetBeginString()
        {
            return _engine.RenderRaw(_begin);
        }

        public string GetEndString()
        {
            return _engine.RenderRaw(_end);
        }

        public virtual AbstractTemplate Assign(string key, string val)
        {
            _engine.Context.Assign(key, val);
            return this;
        }
    }
}
