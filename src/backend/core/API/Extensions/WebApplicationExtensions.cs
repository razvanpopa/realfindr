namespace RealFindr.API.Extensions;

internal static class WebApplicationExtensions
{
    public static void SetupWebApplication(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();

            _ = app.UseDeveloperExceptionPage();
        }

        _ = app.MapControllers();
    }
}
