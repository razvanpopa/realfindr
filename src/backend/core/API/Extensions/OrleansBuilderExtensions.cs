namespace RealFindr.API.Extensions;

internal static class OrleansBuilderExtensions
{
    public static IHostBuilder AddOrleans(this IHostBuilder hostBuilder)
        => hostBuilder.UseOrleans((ctx, siloBuilder) =>
        {
            _ = siloBuilder.UseLocalhostClustering();
            _ = siloBuilder.UseDashboard();
        });
}
