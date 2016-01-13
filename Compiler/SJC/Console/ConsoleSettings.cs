using System;
using System.Runtime.InteropServices;

namespace SJC.Console
{
    [Flags]
    public enum ConsoleColor
    {
        Black = 0x0000,
        Blue = 0x0001,
        Green = 0x0002,
        Cyan = 0x0003,
        Red = 0x0004,
        Magenta = 0x0005,
        Yellow = 0x0006,
        Grey = 0x0007,
        White = 0x0008
    }

    public static class ConsoleSettings
    {
        const int STD_INPUT_HANDLE = -10;
        const int STD_OUTPUT_HANDLE = -11;
        const int STD_ERROR_HANDLE = -12;
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("Kernel32.dll")]
        private static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, int wAttributes);

        public static bool SetForeGroundColour()
        {
            return SetForeGroundColour(ConsoleColor.Grey, false);
        }

        public static bool SetForeGroundColour(ConsoleColor foreGroundColour)
        {
            return SetForeGroundColour(foreGroundColour, true);
        }

        public static bool SetForeGroundColour(ConsoleColor foreGroundColour, bool brightColours)
        {
            IntPtr nConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            int colourMap;

            if (brightColours)
                colourMap = (int)foreGroundColour | (int)ConsoleColor.White;
            else
                colourMap = (int)foreGroundColour;

            return SetConsoleTextAttribute(nConsole, colourMap);
        }
    }
}
