using System;

namespace JavaScript
{
    [RenameClass("String")]
    [ScriptDefaultValue(Value = "null")]
    public class String : Object
    {
        [NonScript]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [NonScript]
        public override bool Equals(object that)
        {
            return base.Equals(that);
        }

        public static implicit operator String(string str)
        {
            return null;
        }

        public static explicit operator string(String str)
        {
            return null;
        }

        public static string operator +(String l, String r)
        {
            return null;
        }

        public static string operator +(string l, String r)
        {
            return null;
        }

        public static string operator +(String l, string r)
        {
            return null;
        }

        public readonly int Length;

        public char this[int index]
        {
            get { return ' '; }
        }

        public char CharAt(int index)
        {
            return ' ';
        }

        public int CharCodeAt(int index)
        {
            return 0;
        }

        public static string FromCharCode(params int[] codes)
        {
            return string.Empty;
        }

        public int IndexOf(string str)
        {
            return 0;
        }

        public int IndexOf(string str, int start)
        {
            return 0;
        }

        public int LastIndexOf(string str)
        {
            return 0;
        }

        public int LastIndexOf(string str, int start)
        {
            return 0;
        }

        public string[] Match(RegularExpression regex)
        {
            return null;
        }

        public string Replace(RegularExpression regex, string newString)
        {
            return null;
        }

        public string Replace(string oldStr, string newStr)
        {
            return null;
        }

        public int Search(RegularExpression regex)
        {
            return 0;
        }

        public string Slice(int start)
        {
            return null;
        }

        public string Slice(int start, int end)
        {
            return null;
        }

        public string[] Split(string delimitor)
        {
            return null;
        }

        public string[] Split(string delimitor, int limit)
        {
            return null;
        }

        public string Substr(int start)
        {
            return null;
        }

        public string Substr(int start, int length)
        {
            return null;
        }

        public string Substring(int from)
        {
            return null;
        }

        public string Substring(int from, int to)
        {
            return null;
        }

        public string ToLowerCase()
        {
            return null;
        }

        public string ToUpperCase()
        {
            return null;
        }

        /*
        public string ValueOf()
        {
            return null;
        }
        */
    }
}
