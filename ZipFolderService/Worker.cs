using BAL.IRepository;

namespace ZipFolderService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConvertZIP _convertZIP;


        public Worker(ILogger<Worker> logger, IConvertZIP convertZIP)
        {
            _logger = logger;
            _convertZIP = convertZIP;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int callTime = Convert.ToInt32(10);
            await Task.Delay(TimeSpan.FromSeconds(callTime), stoppingToken);
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    Console.WriteLine("Sechduler 1:- " + DateTime.Now.ToString("hh:mm:ss"));
                    _logger.LogInformation("Scheduler one called at:- " + DateTime.Now.ToString());
                    _convertZIP.FolderInZIP();
                    await Task.Delay(TimeSpan.FromSeconds(callTime), stoppingToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Scheduler Error at:- " + DateTime.Now.ToString(), ex);
            }
        }
    }
}