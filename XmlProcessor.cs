using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace ManifestVieweRTF
{
    public class XmlProcessor
    {
        public string ApplyXPathToXml(string xmlFilePath, string xpathExpression)
        {
            try
            {
                // Load the XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Create an XPathNavigator
                XPathNavigator navigator = xmlDoc.CreateNavigator();

                // Select nodes using the XPath expression
                XPathNodeIterator nodes = navigator.Select(xpathExpression);

                // Convert the result to a string
                string result = "";
                while (nodes.MoveNext())
                {
                    result += nodes.Current.OuterXml + Environment.NewLine;
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
    }
}
