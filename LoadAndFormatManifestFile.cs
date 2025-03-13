using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoadManifest
{
    class LoadAndFormatManifestFile
    {
        public string SearchAndHighlight { get; set; } = "";
        private string[] fileContents;
        private string ApplyRegexReplace(string text, string LookFor, string ReplaceWith, RegexOptions ro)
        {
            try
            {
                return Regex.Replace(text, LookFor, ReplaceWith, ro);
            }
            catch (System.Exception)
            {
                return text;
              //Do nothing
            }
            
        }

        public StringBuilder TextSource { get; internal set; }

        public string GetRtf()
        {
            StringBuilder _Rtf = new StringBuilder();
            _Rtf.Append(@"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang2057{\fonttbl{\f0\fnil\fcharset0 Consolas;}}\r\n"+
            @"{\colortbl;"+
            @"\red255\green0\blue0;"+
            @"\red0\green176\blue80;" + 
            @"\red0\green100\blue50;" +
            @"\red0\green77\blue187;" +
            @"\red155\green0\blue211;" +
            @"\red247\green150\blue70;" +
            @"\red0\green50\blue150;" +
            @"\red160\green32\blue240;" +
            @"\red224\green17\blue95;" +
            @"\red224\green17\blue95;" +
            @"\red135\green206\blue235;" +
            @"\red65\green105\blue225;" +
            @"\red0\green0\blue0;" +
            @"\red255\green255\blue255;" +
            @"}");

            _Rtf.Append(@"{\*\generator Riched20 10.0.14393}\viewkind4\uc1\fs18 ");
            foreach (var item in fileContents)
            {

                if (item.Trim().StartsWith(@"//")|| item.Trim().StartsWith(@"--"))
                {
                    string itemRtf = item;
                    itemRtf = itemRtf.Replace(@"\", @"\\");
                    itemRtf = $@"\cf3 {itemRtf}\cf0 ";
                    _Rtf.AppendLine($@"{itemRtf}\par");
                }
                else
                {
                    
                    string itemRtf = item;
                    itemRtf = itemRtf.Replace(@"\", @"\\");
                    if (SearchAndHighlight.Length!=0)
                    {
                        itemRtf = ApplyRegexReplace(itemRtf, $@"({SearchAndHighlight})", $@"\highlight11 \cf12 $1\highlight0 \cf0 ", RegexOptions.IgnoreCase);
                        //itemRtf = itemRtf.Replace(SearchAndHighlight, $@"\highlight11 \cf12 {SearchAndHighlight}\highlight0 \cf0 ");
                    }

                    itemRtf = ApplyRegexReplace(itemRtf, @"^([a-zA-Z_0-9]+:)", $@"\highlight13 \cf14 $1\highlight0 \cf0 ", RegexOptions.None);//find variable
                    itemRtf = ApplyRegexReplace(itemRtf, @"([a-zA-Z0-9_]+)=", @"\cf9 $1\cf0 =", RegexOptions.None);//find variable
                    itemRtf = ApplyRegexReplace(itemRtf, @"=([a-zA-Z0-9_]+)\(", @"=\cf8 $1\cf0 (", RegexOptions.None); //find key word
                    itemRtf = ApplyRegexReplace(itemRtf, @"(\$\$[a-zA-Z0-9\._]+\$\$)", @"\cf7 $1\cf0 ", RegexOptions.None);
                    itemRtf = ApplyRegexReplace(itemRtf, @"(\$\$[a-zA-Z0-9\._]+[=,])", @"\cf7 $1\cf0 ", RegexOptions.None);
                    itemRtf = ApplyRegexReplace(itemRtf, @"(""[^,]+"")", @"\cf1 $1\cf0 ", RegexOptions.None);

                    itemRtf = ApplyRegexReplace(itemRtf, @"([{])", @"\$1", RegexOptions.None);
                    itemRtf = ApplyRegexReplace(itemRtf, @"([}])", @"\$1", RegexOptions.None);

                    Debug.WriteLine(itemRtf);
                    _Rtf.AppendLine($@"{itemRtf}\par");
                }
            }

            _Rtf.AppendLine("}\r\n\0");
            //System.IO.File.WriteAllText($@"{Path.GetTempPath()}\resultsForFile.rtf", _Rtf.ToString());

            //Now we have a set of raw text and an RTF file with place holders for the lines (blank or otherwise)
            return _Rtf.ToString();
        }

        internal string GetRtf(string[] textarray)
        {
            fileContents = textarray;
            return (GetRtf());
        }

        public void refreshRTF(RichTextBox rtb)
        {
            rtb.SuspendLayout();
            //rtb.Visible = false;
            int charIndex = rtb.GetCharIndexFromPosition(new Point(0, 0));
           
            int carrotPos = rtb.SelectionStart;
            DumpRichTextBoxContentToFile(rtb);
          
            rtb.Select(charIndex, 0);
            rtb.ScrollToCaret();
            rtb.SelectionStart = carrotPos;

            //rtb.Visible = true;
            rtb.ResumeLayout();

            rtb.Focus();
        }

        public void DumpRichTextBoxContentToFile(RichTextBox richTextBox)
        {
            // Generate a random file name
            richTextBox.SuspendLayout();
            string tempDirectory = Path.GetTempPath();
            string randomFileName = Path.Combine(tempDirectory, Path.GetRandomFileName() + ".txt");

            // Get the content from the RichTextBox
            string content = richTextBox.Text;

            // Write the content to the file
            File.WriteAllText(randomFileName, content);
            loadfile(randomFileName);
            richTextBox.Rtf = GetRtf();
            richTextBox.ResumeLayout();
        }

        public void loadfile(string SourceFile)
        {
            fileContents = System.IO.File.ReadAllLines(SourceFile);
        }

    }
}
