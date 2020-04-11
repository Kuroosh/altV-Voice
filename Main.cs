using AltV.Net;
using System;

namespace AltV.Voice
{
    internal class Voice : Resource
    {
        public override void OnStart()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Debug.OutputDebugString("Alt:V Voice - V." + Main.RESOURCE_VERSION + " started...");
            Console.ResetColor();
        }

        public override void OnStop()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Debug.OutputDebugString("Alt:V Voice - V." + Main.RESOURCE_VERSION + " stopped...");
            Console.ResetColor();
        }
    }
}
