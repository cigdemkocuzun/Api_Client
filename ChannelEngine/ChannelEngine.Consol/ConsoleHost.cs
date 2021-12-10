using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChannelEngine.Consol
{
    class ConsoleHost : IHostedService
    {
        private readonly IConsolService _consolService;
        private readonly IHostApplicationLifetime _hostAppLifetime;

        public ConsoleHost(IHostApplicationLifetime hostAppLifetime, IConsolService consolService)
        {

            _hostAppLifetime = hostAppLifetime;
            _consolService = consolService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _consolService.GetOrdersAndProducts();

                Console.WriteLine("Type product number to update Stock:");
                var productNumber = Console.ReadLine();

                var resultMessage = await _consolService.UpdateProductStock(productNumber);
                Console.WriteLine(resultMessage);
            }
            catch (Exception ex)
            {
                _consolService.ShowError(ex);
            }
            finally
            {
                _hostAppLifetime.StopApplication();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
