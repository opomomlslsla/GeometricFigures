using ConsoleFigureCalculator.Services;
using FigureCalculator;
using FigureCalculator.Factories;
using FigureCalculator.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleFigureCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services
                    .AddScoped<IFigureFactory, FigureFactory>()
                    .AddScoped<Calculator, Calculator>()
                    .AddScoped<Logger, Logger>()
;
                })
                .Build();

            var service = ActivatorUtilities.GetServiceOrCreateInstance<CalculatorService>(host.Services);
            service.MakeSomeCalculations();
        }
    }
}
