using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttacherV3
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyExploits.Module api = new EasyExploits.Module();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
   ██████╗ ███╗   ██╗██╗ ██████╗ ███╗   ███╗ █████╗ 
   ╚════██╗████╗  ██║██║██╔════╝ ████╗ ████║██╔══██╗
    █████╔╝██╔██╗ ██║██║██║  ███╗██╔████╔██║███████║
    ╚═══██╗██║╚██╗██║██║██║   ██║██║╚██╔╝██║██╔══██║
   ██████╔╝██║ ╚████║██║╚██████╔╝██║ ╚═╝ ██║██║  ██║
   ╚═════╝ ╚═╝  ╚═══╝╚═╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝");
            Console.WriteLine("   [+] Join the Discord > https://discord.gg/pzF959KTKh");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   [+] Attaching");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("[<] Hooked");
            Console.WriteLine("[<] Attaching...");
            api.LaunchExploit();
            Console.WriteLine("[<] If you have any Errors download the newest version");
            Console.WriteLine("[<] And join our Discord for support");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
