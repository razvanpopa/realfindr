namespace RealFindr.API.Builder;

using RealFindr.API.Extensions;

internal static class ApplicationSetupBuilder
{
    public static WebApplication CreateWebApplication(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        _ = builder.Host
            .AddOrleans()
            .AddServices();

        return builder.Build();
    }
}
