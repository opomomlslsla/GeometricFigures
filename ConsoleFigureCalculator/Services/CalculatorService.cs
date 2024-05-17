using FigureCalculator;
using FigureCalculator.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigureCalculator.Services
{
    public class CalculatorService
    {
        private readonly Calculator _calculator;
        private readonly Logger _logger;

        public CalculatorService(Calculator calculator, Logger logger) 
        {
            _calculator = calculator;
            _logger = logger;
        }

        public void MakeSomeCalculations()
        {
            try
            {
                var res = _calculator.CalculateFigureArea(FigureType.Circle, 123);
                _logger.ConsoleLogInfo($"Calculation result {res}");

                res = _calculator.CalculateFigureArea(FigureType.Rectangle, 123, 123);
                _logger.ConsoleLogInfo($"Calculation result {res}");

                res = _calculator.CalculateFigureArea(FigureType.Triangle, 45, 34, 22);
                _logger.ConsoleLogInfo($"Calculation result {res}");
            }
            catch(Exception ex)
            {
                _logger.FileLogInfo($"{ex.Message} \n {ex.StackTrace}");
            }

        }

    }
}
