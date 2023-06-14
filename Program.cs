internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

        // use HttpSys web server is command line parameter is httpsys
        if (args.Length > 0 && args[0] == "httpsys")
            ConfigureHttpSys(builder.WebHost);


        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        //app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }


    #pragma warning disable CA1416 // Validate platform compatibility
    static void ConfigureHttpSys(IWebHostBuilder aWebHostBuilder)
    {
        aWebHostBuilder.UseHttpSys(options =>
        {
            options.Authentication.Schemes = Microsoft.AspNetCore.Server.HttpSys.AuthenticationSchemes.None;
            options.Authentication.AllowAnonymous = true;

            //options.MaxConnections = null;
            //options.MaxRequestBodySize = 30000000;

            options.AllowSynchronousIO = true;
            options.EnableResponseCaching = true;
        });
    }

}