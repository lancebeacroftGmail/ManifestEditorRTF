
using System;
using System.IO;

namespace ManifestVieweRTF
{
    public enum ManifestFileType
    {
        Thread,
        Interface,
        Command
    }

    public class CreateFile
    {
        public string WorkFolder { get; set; }
        public string NewFileName { get; set; }
        public ManifestFileType FileType { get; set; }

        public string TextOveride {get;set;}


        public void MakeFile()
        {
            string filePath = Path.Combine(WorkFolder, NewFileName);
            string[] interfaceLines = {  "WWW.BLAZE-IS.COM",
                                "DELIM=$$",
                                "TYPE=INTERFACE",
                                "FROM=Manifest Viewer",
                                "TIMER=900",
                                "DESCRIPTION=Created fro the Manifest Viewer",
                                "TRIGGER=",
                                "TRIGGERFIELDS=",
                                "$$" };

            string[] commandFileLines = {   "WWW.BLAZE-IS.COM",
                                            "DELIM=$$",
                                            "TYPE=READ",
                                            "FROM=ThreadParameters",
                                            "FORMAT=???",
                                            "DESCRIPTION=",
                                            "RESULT=",
                                            "$$ERROR,nvarchar(10),,,,OK or FAIL$$",
                                            "",
                                            "PARAMETERS=",
                                            "//",
                                            "$$",
                                            "",
                                            "HEADER=N",
                                            "DETAIL=N",
                                            "TRAILER=N" };


            try
            {
                if (this.TextOveride!="" && this.FileType==ManifestFileType.Command)
                {
                    File.WriteAllText(filePath, this.TextOveride);
                }
                else
                { 
                switch (this.FileType)
                {
                    case ManifestFileType.Interface:
                        File.WriteAllLines(filePath, interfaceLines);
                        break;
                    case ManifestFileType.Command:
                        File.WriteAllLines(filePath, commandFileLines);
                        break;
                    default:
                        break;
                }
                }

                Console.WriteLine($"File created successfully at {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
