using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aura_OS.XML
{
    class XMLParser
    {
        /// <summary>
        /// Parsing a XML Document
        /// </summary>
        /// <param name="filename">XML File URI</param>
        /// <param name="root">XML Root Element</param>
        /// <param name="element">XML Element</param>
        public void Parse(string filename, string element)
        {
            if (File.Exists(filename))
            {
                String XMLContent = File.ReadAllText(filename);
                Console.WriteLine(GetElementContent(XMLContent, element));
            }
            else
            {
                throw new Exception("file not found");
            }
        }

        private string GetElementContent(String xml, string element)
        {
            Char[] XMLChars = new Char[] { '<', '>', };
            
            xml = xml.Replace("<", "_<");
            xml = xml.Replace("/>", "_>");

            string[] splittedXML = xml.Split(XMLChars);

            foreach (string XMLElement in splittedXML)
            {
                //Console.WriteLine("--- BEGIN ---");
                //Console.WriteLine(line);
                //Console.WriteLine("---- END ----");

                //

                //< = LTS
                //> = GTS

                int LTSindex = XMLElement.IndexOf("_"); //ex: 0
                XMLElement.Remove(LTSindex);
                int GTSindex = XMLElement.IndexOf("_"); //ex: 5
                XMLElement.Remove(GTSindex);

                string line2 = XMLElement.Substring(LTSindex, GTSindex + 1); //return 'test'
                
                if(line2 == element)
                {
                    XMLElement.Remove(LTSindex, GTSindex - 1);
                }

                return XMLElement;
            }
            return "grrr.";
        }

    }
}
