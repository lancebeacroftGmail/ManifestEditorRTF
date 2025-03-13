using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ManifestVieweRTF
{
    class Search
    {
        public string DoSearch(string text, string pattern, string splitOn="\r\n")
        {

            StringBuilder result = new StringBuilder();

            string[] lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.None);
            try
            {
                Regex regex = new Regex(pattern);
                for (int i = 0; i < lines.Length; i++)
                {
                    Match match = regex.Match(lines[i]);
                    if (match.Success)
                    {
                        result.AppendLine($"Line {i + 1}\t{match.Value}\t\"{lines[i]}\"");
                    }
                }
            }
            catch (Exception)
            {

                
            }
            

           

            return result.ToString();

        }
    }
}
