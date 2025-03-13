using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManifestVieweRTF
{
    public static class StringSplitter
    {

        public static string[] SplitStringByTab(string input)
        {
            return SplitString(input, '\t');
        }

        public static string[] SplitStringByComma(string input)
        {
            return SplitString(input, ',');
        }

        public static string[] SplitStringByPipe(string input)
        {
            return SplitString(input, '|');
        }

        public static string[] SplitString(string input, char delimiter)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            return input.Split(delimiter);
        }
    }
}
