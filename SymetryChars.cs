using System.Windows.Forms;

namespace ManifestVieweRTF
{
    class SymmetryChars
    {
        public RichTextBox richTextBox { get; set; }

        public void start()
        {
            richTextBox.KeyDown+= richTextBox_KeyDown;
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            return;

            string symetryChar = "";
            if (e.KeyCode == Keys.OemQuotes) // Detects the '"' key
            {
                symetryChar = "\"\"";
                goto Do_Insert;
            }

            if (e.KeyCode == Keys.D9 && e.Shift) // Detects the '(' key
            {
                symetryChar = "()";
                goto Do_Insert;
            }

            if(e.KeyCode == Keys.OemOpenBrackets) // Detects the '[' key
            {
                symetryChar = "[]";
                goto Do_Insert;
            }

            Do_Insert:
           
            if (symetryChar!="")
            {
                int selectionStart = richTextBox.SelectionStart;
                richTextBox.SelectedText=symetryChar;
                richTextBox.SelectionStart = selectionStart + 1; // Move cursor back 1 character
                e.SuppressKeyPress = true; // Prevents the default '[' character from being added
            }
        }

       
    }
}
