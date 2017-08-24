using Cosmos.HAL;
using Sys = Cosmos.System;

namespace Alve_OS.System.GUI
{
    public class MouseDriver
    {
        protected Mouse m;
        public MouseDriver()
        {
            m = new Mouse();
        }
        public void init(int screenWidth, int screenHeight)
        {
            m.Initialize((uint)screenWidth, (uint)screenHeight);
        }

        public int getX() { return m.X; }

        public int getY() { return m.Y; }

        public Mouse.MouseState Mousestate() { return m.Buttons; }
    }
}