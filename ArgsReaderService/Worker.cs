namespace ArgsReaderService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private string[] _args;

        public Worker(ILogger<Worker> logger, CommandLineArgs args)
        {
            _logger = logger;
            _args = args.Args;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            foreach (var arg in _args)
            {
                _logger.LogInformation($"{arg}");
            }

            return Task.CompletedTask;
        }
    }
}