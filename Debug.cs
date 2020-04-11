using System;

namespace AltV.Voice
{
    public class Debug
    {
        public static void OutputDebugString(string text)
        {
            try
            {
                if (!Main.DEBUG_MODE_ENABLED) { return; }
                Console.WriteLine(DateTime.Now.Hour + " : " + DateTime.Now.Minute + " | : " + text);
            }
            catch { }
        }
        public static void CatchExceptions(string FunctionName, Exception ex)
        {
            try
            {
                if (!Main.DEBUG_MODE_ENABLED) { return; }
                Console.WriteLine("[EXCEPTION " + FunctionName + "] " + ex.Message);
                Console.WriteLine("[EXCEPTION " + FunctionName + "] " + ex.StackTrace);
            }
            catch { }
        }
    }
}
