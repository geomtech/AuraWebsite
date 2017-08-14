using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Alve_OS.System.Translation;

namespace Alve_OS.System.Interpreters
{
    public class AlveScript
    {
        bool echocmd = true;

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

                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("rem " + file);
                }

            }
            if (s.StartsWith("cls"))
            {
                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("cls");
                }
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

                if ((echo == "on") || (echo == "off"))
                {
                    if(echo == "on")
                    {
                        echocmd = true;
                        Kernel.BeforeCommand();
                        Console.WriteLine("echo on");
                    }
                    else
                    {
                        echocmd = false;
                    }
                }
                else
                { 
                    if (echocmd)
                    {
                        Kernel.BeforeCommand();
                        Console.Write(s + " ");
                        Console.WriteLine(echo);
                        Kernel.BeforeCommand();
                        Console.WriteLine(echo);
                    }
                    else
                    {
                        Console.WriteLine(echo);
                    }
                }

                int end = file.IndexOf("echo");
                file = file.Remove(end, echo.Length);
            }
            if (s.StartsWith("pause"))
            {
                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("pause");
                    Kernel.BeforeCommand();
                    Text.Display("touchkeyboard");
                }
                else
                {
                    Text.Display("touchkeyboard");
                }

                Console.ReadKey();
                int end = file.IndexOf("pause");
                file = file.Remove(end, 5);
            }

            if (s.StartsWith("cls"))
            {
                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("cls");
                }
                int location = file.IndexOf("cls");
                file = file.Remove(location, 3);
                Console.Clear();
            }

            if (s.StartsWith("shutdown"))
            {
                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("shutdown");
                }
                int location = file.IndexOf("shutdown");
                file = file.Remove(location, 8);
                Cosmos.System.Power.Shutdown();

            }

            if (s.StartsWith("date"))
            {
                if (echocmd)
                {
                    Kernel.BeforeCommand();
                    Console.WriteLine("date");
                }
                int location = file.IndexOf("date");
                file = file.Remove(location, 4);
                Text.Display("dateoftheday", "date"); //todo

            }


            return file;
        }
    }
}
