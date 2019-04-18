using System.Threading;
using System.Threading.Tasks;
using DatabaseClasses;
using Microsoft.Extensions.Hosting;

namespace WebApplication
{
	public class AirplaneHostedService : BackgroundService
	{
		//private System.Timers.Timer _timer = new System.Timers.Timer();
		protected static Json Storage { get; set; } = DatabaseClasses.Json.Instance;
		public AirplaneHostedService() { }
		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			/*
            _timer.Elapsed += delegate {
                var flightPassenger = generator.Generate();
                flightPassenger.Start();
            };
            _timer.Interval = 5000;
            _timer.Start();
            */
			
			_ = Task.Run(() =>
			{
				var airplanes = Storage.Airplanes;
				foreach (var airplane in airplanes)
				{
					new Thread(() =>
					{
						airplane.Start();
					}).Start();
				}
			}, stoppingToken);
			await Task.Delay(5000, stoppingToken);
		}
		/*public override Task StopAsync(CancellationToken cancellationToken)
		{
			//_timer.Stop();
			return base.StopAsync(cancellationToken);
		}
		public override void Dispose()
		{
			//_timer?.Dispose();
			base.Dispose();
		}*/
	}
}
