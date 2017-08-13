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
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.Blue);

            try
            {
                /* A red Point */
                Pen pen = new Pen(Color.Red);
                canvas.DrawPoint(pen, 69, 69);

                /* A GreenYellow horizontal line */
                pen.Color = Color.GreenYellow;
                canvas.DrawLine(pen, 250, 100, 400, 100);

                /* An IndianRed vertical line */
                pen.Color = Color.IndianRed;
                canvas.DrawLine(pen, 350, 150, 350, 250);

                /* A MintCream diagonal line */
                pen.Color = Color.MintCream;
                canvas.DrawLine(pen, 250, 150, 400, 250);

                /* A PaleVioletRed rectangle */
                pen.Color = Color.PaleVioletRed;
                canvas.DrawRectangle(pen, 350, 350, 80, 60);

                Console.ReadKey();

                /* Let's try to change mode...*/
                canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);

                /* A LimeGreen rectangle */
                pen.Color = Color.LimeGreen;
                canvas.DrawRectangle(pen, 450, 450, 80, 60);

                AlveCanvas.DrawString(100, 100, "sampletexte", 0x000000);

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
