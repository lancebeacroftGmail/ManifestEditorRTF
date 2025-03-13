using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace ManifestVieweRTF
{
    public class ManifestBaseCommandFile
    {
        public StringBuilder Lines { get; set; } = new StringBuilder();
        public string Name { get; set; }="";
        public string Text {
            get { return Lines.ToString(); }
        }
     
    }

    public class ManifestBaseCommandFiles
    {
        public List<ManifestBaseCommandFile> CommandFileTexts { get; private set; } = new List<ManifestBaseCommandFile>();

        public void ReadManifestFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file {filePath} does not exist.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                ManifestBaseCommandFile currentCommandFileText = null;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        if (currentCommandFileText != null)
                        {
                            CommandFileTexts.Add(currentCommandFileText);
                        }
                        string section = line.Replace("[", "").Replace("]", "");
                        currentCommandFileText = new ManifestBaseCommandFile() { Name=section};
                    }
                    else if (currentCommandFileText != null)
                    {
                        currentCommandFileText.Lines.AppendLine(line);
                    }
                }

                if (currentCommandFileText != null)
                {
                    CommandFileTexts.Add(currentCommandFileText);
                }
            }
        }
    }
}