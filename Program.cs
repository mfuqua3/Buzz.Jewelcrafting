using Buzz.Jewelcrafting;
using Serilog;

Host.CreateDefaultBuilder()
    .ConfigureWebHostDefaults(webBuilder =>
    {
        var port = Environment.GetEnvironmentVariable("PORT");
        if (!string.IsNullOrEmpty(port))
        {
            webBuilder.UseUrls($"http://*:{port}");
        }

        webBuilder.UseStartup<Startup>();
    })
    .UseSerilog((ctx, lc) => { lc.ReadFrom.Configuration(ctx.Configuration); })
    .Build()
    .Run();