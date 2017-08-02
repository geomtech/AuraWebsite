using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alve_OS.System.Interpreter
{
    public class App
    {
        public void Init(string file)
        {
            string script = File.ReadAllText(Kernel.current_directory + file);

            char[] delimiterChars = { ' ', '\n', '.', ':', '\t' };

            string[] words = script.Split(delimiterChars);

            foreach (string s in words)
            {
                script = Script(s, script);
            }
        }

        public string Script(string s, string file)
        {
            if (s.StartsWith("rem"))
            {
                int end = file.IndexOf("rem");
                file = file.Remove(end, 3);
            }
            if (s.StartsWith("cls"))
            {
                int location = file.IndexOf("cls");
                file = file.Remove(location, 3);
                Console.Clear();
            }
            if (s.StartsWith("echo"))
            {
                int location = file.IndexOf("echo");
                string echo = file.Remove(0, location + 5);
                echo = echo.Remove(echo.IndexOf("\n"), echo.Length - (echo.IndexOf("\n")));
                echo = echo.Remove(echo.Length - 1, 1);

                if (echo.Equals("echo off"))
                {
                    //TODO
                }
                else
                {
                    Console.WriteLine(echo);
                }

                int end = file.IndexOf("echo");
                file = file.Remove(end, echo.Length);
            }
            if (s.StartsWith("pause"))
            {
                Console.ReadKey();
                int end = file.IndexOf("pause");
                file = file.Remove(end, 5);
            }
            return file;
        }
    }
}
