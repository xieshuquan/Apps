using System;
using System.Collections.Generic;
using System.Text;

namespace System.Extensions
{
    public static class StringExtensions
    {
        public static bool IgnoreCaseEquals(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
