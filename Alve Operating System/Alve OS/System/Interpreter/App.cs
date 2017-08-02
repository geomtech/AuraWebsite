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
            Script(script);
        }

        public void Script(string script)
        {
            
        }
    }
}
