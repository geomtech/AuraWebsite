using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alve_OS.System.GUI
{
    class CGS
    {
        static Canvas canvas;

        public static void Start()
        {
            Mode screenmode = new Mode(1366, 768, ColorDepth.ColorDepth32);
            canvas = FullScreenCanvas.GetFullScreenCanvas(screenmode);
            canvas.Clear(Color.White);

            try
            {


                Console.ReadKey();

                Cosmos.System.Power.Shutdown();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: " + e.Message);
                Console.ReadKey();
                Cosmos.System.Power.Shutdown();
            }
        }
    }
}
