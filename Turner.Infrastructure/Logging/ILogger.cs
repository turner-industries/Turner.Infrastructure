namespace Turner.Infrastructure.Logging
{
    public interface ILogger
    {
        void Information(string logMessage);
        void Debug(string logMessage);
    }
}
