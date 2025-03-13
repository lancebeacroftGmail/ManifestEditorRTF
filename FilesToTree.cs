using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManifestVieweRTF
{
    public class FilesToTree
    {
        public string SelectFolder()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the description for the dialog
                folderBrowserDialog.Description = "Select a directory";

                // Show the dialog and check if the user clicked OK
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Return the selected path
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return "";

        }

        public static bool MatchPattern(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        public void PopulateTreeViewWithFilesOfType(string directoryPath, string regexpattern,TreeView treeView, string parentNodeName = "Interfaces", string type = "TYPE=INTERFACE",string typeCode="INT", TreeNode  existingNode =null)
        {
            // Create the root node for interfaces

            TreeNode interfacesNode= null;

            if (existingNode == null)
            {
              
               
                interfacesNode = new TreeNode(parentNodeName);
                treeView.Nodes.Add(interfacesNode);
            }
            else 
            {
                interfacesNode = new TreeNode(parentNodeName);
                existingNode.Nodes.Add(interfacesNode);
            }

           

            // Get all files in the directory
            string[] files = Directory.GetFiles(directoryPath);
            string[] splits = { ","};
            string[] types = type.Split(splits,System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string file in files)
            {
                if (MatchPattern(file, regexpattern))
                {

                
                // Read the file content
                string content = File.ReadAllText(file);

                // Check if the file contains the text "TYPE=INTERFACE"
                bool AllContentMet = true;
                foreach (var item in types)
                {
                    if(!content.Contains($"{item}"))
                    {
                        AllContentMet = false;
                          break;
                    }
                }

                if (AllContentMet)
                {
                    // Add the file name to the tree under the "Interfaces" node
                    FileDetails fd = new FileDetails();
                    fd.FileName = Path.GetFileName(file);
                    fd.FilePath = Path.GetDirectoryName(file);
                    fd.FileType = typeCode;

                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = fd;
                    interfacesNode.Nodes.Add(fileNode);
                }
            }
            }

            // Expand the "Interfaces" node
            //   interfacesNode.Expand();
        }
    }
}
