using System.Runtime.InteropServices;
using Autofac;
using Common;
using Common.Startup;
using Common.Utils;
using OpenSteamworks;

namespace ClientConsole;

public static class Program
{
    public static IContainer container;
    [STAThread]
    public static void Main(string[] args)
    {
        MainAsync(args).Wait();
    }
    [STAThread]
    public static async Task MainAsync(string[] args)
    {
        ExtendedProgress<int> handler = new ExtendedProgress<int>(0, 100);
        handler.ProgressChanged += (object? sender, int current) =>
        {
            string endPart = "";
            if (!handler.Throbber) {
                endPart = " with progress " + current + " of " + handler.MaxProgress;
            }
            Console.WriteLine("Bootstrapper is " + handler.Operation + ", " + handler.SubOperation + endPart);
        };

        container = await StartupController.Startup<ClientConsoleAutofacRegistrar>(handler);
        Console.WriteLine("Started up");
        
        container.Resolve<SteamClient>().LogClientState();

        do
        {
            System.Threading.Thread.Sleep(10);
        } while (true);
    }

}