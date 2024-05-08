// See https://aka.ms/new-console-template for more information
using FactoryWithComposition;
using FactoryWithComposition.Processors;
using FactoryWithComposition.Service;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddTransient<IProcessorFactory, ProcessorFactory>();
builder.Services.AddTransient<ICacheService, CacheService>();
using IHost host = builder.Build();

TestMethod(action: "B");
TestMethod(action: "A");

await host.StartAsync();

void TestMethod(string action)
{
    using IServiceScope serviceScope = host.Services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    var client = new Client(provider.GetRequiredService<IProcessorFactory>());
    var (p, v) = client.GetProcessor(action);
    foreach (var item in v)
    {
        Console.WriteLine(item.GetType().FullName + " " + p.GetType().FullName);
    }
}