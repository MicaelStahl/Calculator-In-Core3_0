using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_In_Core3_0
{
    class Display
    {
        public void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
