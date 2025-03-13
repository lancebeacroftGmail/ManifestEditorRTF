using System;
using System.IO;

namespace ManifestVieweRTF
{
    public static class FileSaver
    {
        public static void SaveFile(string directory, string fileName, string content)
        {
            string filePath = Path.Combine(directory, fileName);

            // Check if the file already exists
            if (File.Exists(filePath))
            {
                // Create a backup of the existing file
                string backupFilePath = filePath + $".{DateTime.Now.ToString("yyyy_MMM_dd_HH_mm_ss")}.BAK.";
                File.Move(filePath, backupFilePath);
            }

            // Write the new content to the file
            File.WriteAllText(filePath, content);

            Console.WriteLine($"File saved to {filePath}");
        }
    }
}
