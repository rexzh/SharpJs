using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript.Compatible
{
    [NonScript]
    public static class StringExtension
    {
        public static char CharAt(this string str, int index)
        {
            return ' ';
        }

        public static int CharCodeAt(this string str, int index)
        {
            return 0;
        }

        public static string[] Match(this string str, RegularExpression regex)
        {
            return null;
        }

        public static string Replace(this string str, RegularExpression regex, string newString)
        {
            return null;
        }

        public static string Replace(this string str, string oldStr, string newStr)
        {
            return null;
        }

        public static int Search(this string str, RegularExpression regex)
        {
            return 0;
        }

        public static string Slice(this string str, int start)
        {
            return null;
        }

        public static string Slice(this string str, int start, int end)
        {
            return null;
        }

        public static string[] Split(this string str, string delimitor)
        {
            return null;
        }

        public static string[] Split(this string str, string delimitor, int limit)
        {
            return null;
        }

        public static string Substr(this string str, int start)
        {
            return null;
        }

        public static string Substr(this string str, int start, int length)
        {
            return null;
        }

        public static string ToLowerCase(this string str)
        {
            return null;
        }

        public static string ToUpperCase(this string str)
        {
            return null;
        }
    }
}
