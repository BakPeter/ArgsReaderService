using ArgsReaderService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton(new CommandLineArgs(args));

        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
