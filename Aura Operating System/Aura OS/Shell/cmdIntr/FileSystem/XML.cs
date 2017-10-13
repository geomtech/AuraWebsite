/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Command Interpreter - Run Script
* PROGRAMMER(S):    DA CRUZ Alexy <dacruzalexy@gmail.com>
*/

using Aura_OS.XML;
using System.IO;
using L = Aura_OS.System.Translation;

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
                XMLParser xMLParser = new XMLParser();
                xMLParser.Parse(@"0:\test.xml", "test");
            
        }

    }
}
