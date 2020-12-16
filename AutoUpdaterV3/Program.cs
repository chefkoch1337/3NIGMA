using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoUpdaterV3
{
    class Program
    {
        public static WebClient wc = new WebClient();
        static void Main(string[] args)
        {
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
            Console.WriteLine("   [+] Fetching latest Files from https://github.com/chefkochh/3NIGMA");
            Console.WriteLine("   [+] Deleting old Files");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            if (File.Exists("AttacherV3.exe"))
            {
                Console.WriteLine("[>] Deleted AttacherV3.exe");
                File.Delete("AttacherV3.exe");
                Thread.Sleep(96);
            }
            if (File.Exists("3NIGMA.exe"))
            {
                Console.WriteLine("[>] Deleted 3NIGMA.exe");
                File.Delete("3NIGMA.exe");
                Thread.Sleep(96);

            }
            if (File.Exists("EasyExploits.dll"))
            {
                Console.WriteLine("[>] Deleted EasyExploits.dll.exe");
                File.Delete("EasyExploits.dll");
                Thread.Sleep(96);

            }
            Console.WriteLine("[>] Done");

            Console.Clear();
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
            Console.WriteLine("   [+] Fetching latest Files from https://github.com/chefkochh/3NIGMA");
            Console.WriteLine("   [+] Downloading new Files");
            Console.WriteLine("________________________________________________________________________________________________________________________");

            Console.WriteLine("[>] Downloading AttacherV3.exe");
            wc.DownloadFile("https://github.com/chefkochh/3NIGMA/raw/master/Cool/bin/Debug/bin/AttacherV3.exe", "AttacherV3.exe");
            Console.WriteLine("[>] Downloading 3NIGMA.exe");
            wc.DownloadFile("https://github.com/chefkochh/3NIGMA/raw/master/Cool/bin/Debug/bin/3NIGMA.exe", "3NIGMA.exe");
            Console.WriteLine("[>] Downloading EasyExploits.dll");
            wc.DownloadFile("https://github.com/chefkochh/3NIGMA/raw/master/Cool/bin/Debug/bin/EasyExploits.dll", "EasyExploits.dll");
            Console.WriteLine("[>] Done");
            Console.ReadLine();
            Process.Start("3NIGMA.exe");
            Environment.Exit(0);
        }
    }
}
