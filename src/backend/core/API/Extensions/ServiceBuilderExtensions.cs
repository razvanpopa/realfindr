namespace RealFindr.API.Extensions;

internal static class ServicesBuilderExtensions
{
    public static IHostBuilder AddServices(this IHostBuilder hostBuilder)
        => hostBuilder.ConfigureServices(services =>
        {
            _ = services.AddControllers();
            _ = services.AddEndpointsApiExplorer();
            _ = services.AddSwaggerGen();
        });
}
