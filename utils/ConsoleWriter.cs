using GM_Frota.interfaces;

namespace GM_Frota.utils
{
    public static class ConsoleWriter
    {
        public static void WriteStart()
        { Console.WriteLine("=========================================="); }

        public static void WriteEmptyLine()
        { Console.WriteLine("||"); }

        public static void WriteLine(string campo, string valor)
        { Console.WriteLine($"|| {campo}: {valor} "); }

        public static void WriteEnd()
        { Console.WriteLine("=========================================="); }
    }
}
