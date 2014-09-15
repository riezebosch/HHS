using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHS.Tests
{
    static class StringHelper
    {
        public static string RemoveAllVowels(this string input)
        {
            var sb = new StringBuilder();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var item in input)
            {
                if (!vowels.Contains(item))
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}
