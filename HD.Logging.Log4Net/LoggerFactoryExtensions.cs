using HD.Logging.Log4Net;
using System;

namespace HD.Logging.Abstractions
{
    public static class LoggerFactoryExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory)
        {
            return AddLog4Net(factory, LogLevel.Debug);
        }

        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, LogLevel minLevel, string logDir = null, string layoutPattern = null, string datePattern = null, bool includeCategory = true, string configPath = null)
        {
            return AddLog4Net(
               factory,
               (_, logLevel) => logLevel >= minLevel,
               logDir,
               layoutPattern,
               datePattern,
               includeCategory,
               configPath);
        }

        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, Func<string, LogLevel, bool> filter, string logDir = null, string layoutPattern = null, string datePattern = null, bool includeCategory = true, string configPath = null)
        {
            factory.AddProvider(new Log4NetLoggerProvider(filter, logDir, layoutPattern, datePattern, includeCategory, configPath));
            return factory;
        }
    }
}