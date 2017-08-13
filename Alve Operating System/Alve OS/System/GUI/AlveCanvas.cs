using Cosmos.Core.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alve_OS.System.GUI
{
    unsafe class AlveCanvas
    {
        public static uint* Buffer;
        public static int Width;
        public int Height;
        private bool usesExisting;

        public static void DrawString(int x, int y, string content, uint colour)
        {
            GL.DrawText(Buffer, Width, x, y, content, colour);
        }
    }
}
