using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();

builder.Logging.AddDebug();
builder.Services.AddOcelot().AddCacheManager(settings => settings.WithDictionaryHandle());
builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
var app = builder.Build();
app.UseRouting();
//app.MapGet("/", () => "Hello World!");
await app.UseOcelot();
app.Run();
