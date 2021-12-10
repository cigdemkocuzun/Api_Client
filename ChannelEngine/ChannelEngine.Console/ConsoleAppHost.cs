using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Console
{
    public class ConsoleAppHost : IHostedService
    {
        //private readonly IConsoleAppDisplay _appDisplay;
        private readonly IHostApplicationLifetime _hostAppLifetime;
        //private readonly IProductService _orderService;

        public ConsoleAppHost(IHostApplicationLifetime hostAppLifetime)
        {

            _hostAppLifetime = hostAppLifetime;
            //_orderService = orderService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                //await _orderService.FetchAllOrders();
                await DisplayResults();
            }
            catch (Exception ex)
            {
                //_appDisplay.DisplayError(ex);
      
            }
            finally
            {
                _hostAppLifetime.StopApplication();
            }
        }

        private async Task DisplayResults()
        {
        
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
