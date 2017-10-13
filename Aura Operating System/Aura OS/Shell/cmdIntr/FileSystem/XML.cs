/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Command Interpreter - Run Script
* PROGRAMMER(S):    DA CRUZ Alexy <dacruzalexy@gmail.com>
*/

using TObject.Shared;
using System.IO;
using L = Aura_OS.System.Translation;
using System;

namespace Aura_OS.Shell.cmdIntr.FileSystem
{
    class XML
    {
        private static string HelpInfo = "";

        /// <summary>
        /// Getter and Setters for Help Info.
        /// </summary>
        public static string HI
        {
            get { return HelpInfo; }
            set { HelpInfo = value; /*PUSHED OUT VALUE (in)*/}
        }

        /// <summary>
        /// Empty constructor. (Good for debug)
        /// </summary>
        public XML() { }

        /// <summary>
        /// c = command, c_Run
        /// </summary>
        /// <param name="run">The script you wish to start</param>
        /// /// <param name="startIndex">The start index for remove.</param>
        /// <param name="count">The count index for remove.</param>
        public static void c_XML()
        {
            string xml = File.ReadAllText(@"0:\test.xml");
            NanoXMLDocument nanoXMLDocument = new NanoXMLDocument(xml);
            string myAttribute = nanoXMLDocument.RootNode["food"].GetAttribute("test").Value;
            Console.WriteLine(myAttribute);
        }

    }
}
