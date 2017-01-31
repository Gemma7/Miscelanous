using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupingOperators.Classes
{
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return GetCanonicalString(x) == GetCanonicalString(y);
        }

        private object GetCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();

            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }

        public int GetHashCode(string obj)
        {
            return GetCanonicalString(obj).GetHashCode();
        }
    }
}
