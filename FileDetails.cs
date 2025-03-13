using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManifestVieweRTF
{
    class FileDetails
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string FullFileName { get { return Path.Combine(this.FilePath, this.FileName); } }

        public string TextChanged { get; internal set; }
    }
}
