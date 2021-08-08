using System;
using Microsoft.Extensions.Logging;

namespace WorldStat.Core.Database.Contexts
{
    public class DbLoggerProvider : ILoggerProvider
    {
        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger();
        }
    }

    public class DbLogger : ILogger
    {
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //File.AppendAllText(PathManager.LogPath, formatter(state, exception));
            Console.WriteLine(formatter(state, exception));
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
    }
}
