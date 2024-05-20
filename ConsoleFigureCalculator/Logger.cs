
using ConsoleFigureCalculator.Interfaces;

namespace ConsoleFigureCalculator
{
    public class Logger : ICustomLogger
    {
        private static string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly string appStorageFolder = Path.Combine(baseFolder, "CalculatorLogs.txt");
        public void ConsoleLogError(string message)
        {
            Console.WriteLine("[ERROR]: " + message);
        }

        public void ConsoleLogInfo(string message)
        {
            Console.WriteLine("[INFO]" + message);
        }

        public void FileLogError(string message)
        {
            FileLog("[ERROR]" + message);
        }

        public void FileLogInfo(string message)
        {
            FileLog("[INFO]" + message);
        }

        private void FileLog(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(appStorageFolder, true, System.Text.Encoding.UTF8))
            {
                writer.WriteLine(message);
            }
        }

    }
}
