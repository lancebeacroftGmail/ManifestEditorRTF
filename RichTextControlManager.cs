using System.Drawing;
using System.Windows.Forms;

namespace ManifestVieweRTF
{
    class RichTextControlManager
    {
        public string GetLineText(RichTextBox richTextBox, int lineNumber)
        {
            if (lineNumber < 1 || lineNumber > richTextBox.Lines.Length)
            {
                MessageBox.Show("Line number out of range.");
                return string.Empty;
            }

            return richTextBox.Lines[lineNumber - 1];
        }

        public int GetCurrentLine(RichTextBox richTextBox)
        {
            int charIndex = richTextBox.SelectionStart;
            return richTextBox.GetLineFromCharIndex(charIndex) + 1;
        }

        public void HighlightLine(RichTextBox richTextBox, int lineNumber)
        {

            int startIndex = richTextBox.GetFirstCharIndexFromLine(lineNumber);
            int length = richTextBox.Lines[lineNumber].Length;

            richTextBox.Select(startIndex, length);
            richTextBox.SelectionBackColor = Color.Yellow; // Highlight with yellow background

        }

        public void JumpToLine(RichTextBox richTextBox, int GotoLine)
        {
            if (GotoLine < 1 || GotoLine > richTextBox.Lines.Length)
            {
                MessageBox.Show("Line number out of range.");
                return;
            }

            int charIndex = richTextBox.GetFirstCharIndexFromLine(GotoLine - 1);
            richTextBox.Select(charIndex, 0);
            richTextBox.ScrollToCaret();
        }
    }
}
