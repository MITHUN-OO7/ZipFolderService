using BAL.IRepository;
using BAL.Repository;
using ZipFolderService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IConvertZIP, ConvertZIP>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
