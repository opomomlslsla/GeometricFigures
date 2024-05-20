namespace ConsoleFigureCalculator.Interfaces
{
    public interface ICustomLogger
    {
        void ConsoleLogError(string message);
        void ConsoleLogInfo(string message);
        void FileLogError(string message);
        void FileLogInfo(string message);
    }
}