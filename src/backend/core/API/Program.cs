namespace RealFindr.API;

using RealFindr.API.Builder;
using RealFindr.API.Extensions;

internal sealed class Program
{
    private static async Task Main(string[] args)
    {
        using WebApplication app = ApplicationSetupBuilder.CreateWebApplication(args);

        app.SetupWebApplication();

        await app.RunAsync();
    }
}
