using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using Impostor.Patcher.Shared;
using Impostor.Patcher.Shared.Events;

namespace Impostor.Patcher.Cli
{
    internal static class Program
    {
        private static readonly AmongUsModifier Modifier = new AmongUsModifier();

        internal static Task<int> Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<string>(
                    "--address",
                    "IP Address of the server, will prompt if not specified"
                ),
                new Option<string>(
                    "--name",
                    () => AmongUsModifier.DefaultRegionName,
                    "Name for server region"
                )
            };

            rootCommand.Handler = CommandHandler.Create<string, string>((address, name) =>
            {
                Modifier.RegionName = name;
                Modifier.Error += ModifierOnError;
                Modifier.Saved += ModifierOnSaved;

                //Console.WriteLine("Welcome to Impostor");
                Console.WriteLine("Witaj! Chcesz zagrac na Impostors.ga?");

                if (Modifier.TryLoadRegionInfo(out var regionInfo))
                {
                    //Console.WriteLine($"Currently selected region: {regionInfo.Name} ({regionInfo.Ping}, {regionInfo.Servers.Count} server(s))");
                    Console.WriteLine($"Aktualnie wybrany region, to: {regionInfo.Name} ({regionInfo.Ping}, {regionInfo.Servers.Count} serwer(ow))");
                }

                if (address != null)
                {
                    return Modifier.SaveIpAsync(address);
                }

                return PromptAsync();
            });

            return rootCommand.InvokeAsync(args);
        }

        private static void ModifierOnSaved(object sender, SavedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Region zostal zapisany! Zamknij to okno oraz (ponownie) uruchom Among Us.");
            Console.ResetColor();
        }

        private static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ModifierOnError(object sender, ErrorEventArgs e)
        {
            WriteError(e.Message);
        }

        private static async Task PromptAsync()
        {
            //Console.WriteLine("Please enter in the IP Address of the server you would like to use for Among Us");
            //Console.WriteLine("If you want to stop playing on the server, simply select another region");
            
            Console.WriteLine("Kliknik klawisz enter, aby zmienic region na Impostors.ga!");
            Console.WriteLine("Jesli chcesz grac w zwyklego Among Us, po prostu zmien region, np. na Europa.");

            Console.Write("> ");
            
            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    await Modifier.SaveIpAsync("");
                    await Task.Delay(30000);
                    break;
                }
            }
        }
    }
}
