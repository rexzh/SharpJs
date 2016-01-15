using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using RexToy;
using RexToy.Xml;

using SJC.Compiler.Template;

namespace SJC.Compiler
{
    public class CodeTemplate
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private string _memberSeparator;
        public string MemberSeparator
        {
            get { return _memberSeparator; }
        }

        private bool _typeIndent;
        public bool TypeIndent
        {
            get { return _typeIndent; }
        }

        private bool _memberIndent;
        public bool MemberIndent
        {
            get { return _memberIndent; }
        }

        private string _rootType;
        public string RootType
        {
            get { return _rootType; }
        }

        private string _baseKeyword;
        public string BaseKeyword
        {
            get { return _baseKeyword; }
        }

        private string _namespaceBeginTemplate;
        private string _namespaceEndTemplate;

        private string _classBeginTemplate;
        private string _staticClassBeginTemplate;
        private string _classEndTemplate;
        private string _staticClassEndTemplate;

        public bool SupportCtor { get; private set; }
        private string _ctorBeginTemplate;
        private string _ctorEndTemplate;

        public bool SupportInterface { get; private set; }
        private string _interfaceBeginTemplate;
        private string _interfaceEndTemplate;

        public bool SupportEnum { get; private set; }
        private string _enumBeginTemplate;
        private string _enumEndTemplate;

        public bool SupportUsing { get; private set; }
        private string _usingBeginTemplate;
        private string _usingEndTemplate;

        private string _fieldBeginTemplate;
        private string _fieldEndTemplate;
        private string _staticFieldBeginTemplate;
        private string _staticFieldEndTemplate;

        private string _methodBeginTemplate;
        private string _methodEndTemplate;
        private string _staticMethodBeginTemplate;
        private string _staticMethodEndTemplate;

        private CodeTemplate(string text)
        {
            XDoc x = XDoc.LoadFromString(text);
            var xName = x.NavigateToSingle("name");
            this._name = xName.GetStringValue();

            var xMemberSeparator = x.NavigateToSingleOrNull("memberSeparator");
            if (xMemberSeparator == null)
            {
                this._memberSeparator = ",";
            }
            else
            {
                this._memberSeparator = xMemberSeparator.GetStringValue();
            }

            var xTypeIdent = x.NavigateToSingleOrNull("identType");
            if (xTypeIdent == null)
                this._typeIndent = true;
            else
                this._typeIndent = xTypeIdent.GetValue<bool>() ?? true;

            var xMemberIdent = x.NavigateToSingleOrNull("identMember");
            if (xMemberIdent == null)
                this._memberIndent = true;
            else
                this._memberIndent = xMemberIdent.GetValue<bool>() ?? true;

            var xRootType = x.NavigateToSingleOrNull("root");
            if (xRootType == null)
                this._rootType = "";
            else
                this._rootType = xRootType.GetStringValue();

            var xBaseKeyword = x.NavigateToSingleOrNull("base");
            if (xBaseKeyword == null)
                this._baseKeyword = "";
            else
                this._baseKeyword = xBaseKeyword.GetStringValue();

            var xNamespace = x.NavigateToSingle("namespace");
            var xClass = x.NavigateToSingle("class");
            var xStaticClass = x.NavigateToSingle("staticClass");
            var xCtor = x.NavigateToSingleOrNull("constructor");
            var xInterface = x.NavigateToSingleOrNull("interface");
            var xEnum = x.NavigateToSingleOrNull("enum");
            var xUsing = x.NavigateToSingleOrNull("using");
            var xField = x.NavigateToSingleOrNull("field");
            var xMethod = x.NavigateToSingleOrNull("method");
            var xStaticField = x.NavigateToSingleOrNull("staticField");
            var xStaticMethod = x.NavigateToSingleOrNull("staticMethod");

            string ns = xNamespace.GetStringValue().Trim();
            if (string.IsNullOrEmpty(ns))
            {
                _namespaceBeginTemplate = string.Empty;
                _namespaceEndTemplate = string.Empty;
            }
            else
                SplitMultiLineTemplate(ns, out _namespaceBeginTemplate, out _namespaceEndTemplate);

            SplitMultiLineTemplate(xClass.GetStringValue(), out this._classBeginTemplate, out this._classEndTemplate);
            SplitMultiLineTemplate(xStaticClass.GetStringValue(), out this._staticClassBeginTemplate, out this._staticClassEndTemplate);

            if (xInterface == null || string.IsNullOrEmpty(xInterface.GetStringValue().Trim()))
                this.SupportInterface = false;
            else
            {
                SplitMultiLineTemplate(xInterface.GetStringValue(), out this._interfaceBeginTemplate, out this._interfaceEndTemplate);
                this.SupportInterface = true;
            }

            if (xEnum == null || string.IsNullOrEmpty(xEnum.GetStringValue().Trim()))
                this.SupportEnum = false;
            else
            {
                SplitMultiLineTemplate(xEnum.GetStringValue(), out this._enumBeginTemplate, out this._enumEndTemplate);
                this.SupportEnum = true;
            }

            if (xCtor != null)
            {
                var ctorTemplate = xCtor.GetStringValue().Trim();
                SplitMultiLineTemplate(ctorTemplate, out this._ctorBeginTemplate, out this._ctorEndTemplate);
                this.SupportCtor = true;
            }
            else
            {
                this.SupportCtor = false;
            }

            SplitMultiLineTemplate(xMethod.GetStringValue().Trim(), out _methodBeginTemplate, out _methodEndTemplate);
            SplitMultiLineTemplate(xStaticMethod.GetStringValue().Trim(), out _staticMethodBeginTemplate, out _staticMethodEndTemplate);

            if (xField != null)
            {
                var fieldTemplate = xField.GetStringValue().Trim();
                SplitSingleLineTemplate(fieldTemplate, out _fieldBeginTemplate, out _fieldEndTemplate);
            }

            if (xUsing == null || string.IsNullOrEmpty(xUsing.GetStringValue().Trim()))
                this.SupportEnum = false;
            else
            {
                var usingTemplate = xUsing.GetStringValue().Trim();
                SplitSingleLineTemplate(usingTemplate, out _usingBeginTemplate, out _usingEndTemplate);
                this.SupportUsing = true;
            }

            if (xStaticField != null)
            {
                var fieldTemplate = xStaticField.GetStringValue().Trim();
                SplitSingleLineTemplate(fieldTemplate, out _staticFieldBeginTemplate, out _staticFieldEndTemplate);
            }
        }

        private static void SplitSingleLineTemplate(string template, out string begin, out string end)
        {
            var idx = template.IndexOf("%code%");
            begin = template.Substring(0, idx);
            end = template.Substring(idx + 6);
        }

        private static void SplitMultiLineTemplate(string template, out string begin, out string end)
        {
            int codeLineIdx = -1;

            var lines = template.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.Trim() == "%code%")
                    codeLineIdx = i;
            }

            Assertion.IsTrue(codeLineIdx != -1, "Code template not correct, line %code% not found.");

            begin = string.Empty;
            for (int i = 0; i < codeLineIdx; i++)
                begin += lines[i] + Environment.NewLine;

            end = string.Empty;
            for (int i = codeLineIdx + 1; i < lines.Length; i++)
                end += lines[i] + Environment.NewLine;
            end = end.RemoveEnd(Environment.NewLine);
        }

        public static CodeTemplate Parse(string path)
        {
            var txt = File.ReadAllText(path);
            return new CodeTemplate(txt);
        }

        public static CodeTemplate Parse(StreamReader stream)
        {
            var txt = stream.ReadToEnd();
            return new CodeTemplate(txt);
        }

        internal NamespaceTemplate CreateNamespaceTemplate()
        {
            return new NamespaceTemplate(_namespaceBeginTemplate, _namespaceEndTemplate);
        }

        internal BasicClassTemplate CreateClassTemplate(bool isStatic)
        {
            if (isStatic)
                return new StaticClassTemplate(this._staticClassBeginTemplate, this._staticClassEndTemplate);
            else
                return new ClassTemplate(this._classBeginTemplate, this._classEndTemplate);
        }

        internal BasicClassTemplate CreateInterfaceTemplate()
        {
            return new InterfaceTemplate(this._interfaceBeginTemplate, this._interfaceEndTemplate);
        }

        internal BasicClassTemplate CreateEnumTemplate()
        {
            return new EnumTemplate(this._enumBeginTemplate, this._enumEndTemplate);
        }

        internal BasicFieldTemplate CreateFieldTemplate(bool isStatic)
        {
            if (isStatic)
                return new StaticFieldTemplate(this._staticFieldBeginTemplate, this._staticFieldEndTemplate);
            else
                return new FieldTemplate(this._fieldBeginTemplate, this._fieldEndTemplate);
        }

        internal BasicMethodTemplate CreateMethodTemplate(bool isStatic)
        {
            if (isStatic)
                return new StaticMethodTemplate(this._staticMethodBeginTemplate, this._staticMethodEndTemplate);
            else
                return new MethodTemplate(this._methodBeginTemplate, this._methodEndTemplate);
        }

        internal BasicMethodTemplate CreateConstructorTemplate()
        {
            return new ConstructorTemplate(this._ctorBeginTemplate, this._ctorEndTemplate);
        }

        internal UsingTemplate CreateUsingTemplate()
        {
            return new UsingTemplate(this._usingBeginTemplate, this._usingEndTemplate);
        }
    }
}
