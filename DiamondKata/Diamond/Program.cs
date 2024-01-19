using Diamond.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Diamond;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<IDiamondKata, DiamondKata>();
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        if (args.Length > 0)
        {
            var diamondKata = serviceProvider.GetRequiredService<IDiamondKata>();
            Console.WriteLine(diamondKata.GetDiamondKata(args[0]));
        }
    }
}