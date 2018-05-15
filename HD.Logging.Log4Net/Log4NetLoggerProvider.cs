using HD.Logging.Abstractions;
using log4net.Repository;
using System;

namespace HD.Logging.Log4Net
{
    public class Log4NetLoggerProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly bool _includeCategory;
        private readonly ILoggerRepository _loggerRepository;

        public Log4NetLoggerProvider(Func<string, LogLevel, bool> filter, string logDir = null, string layoutPattern = null, string datePattern = null, bool includeCategory = true, string configPath = null)
        {
            _filter = filter;
            _includeCategory = includeCategory;
            _loggerRepository = Log4NetHelper.Init(logDir, layoutPattern, datePattern, configPath);
        }

        /// <inheritdoc /> 
        public ILogger CreateLogger(string name)
        {
            return new Log4NetLogger(name, _filter, _includeCategory, _loggerRepository);
        }

        public void Dispose()
        {
        }
    }
}
