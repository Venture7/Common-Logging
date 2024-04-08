using LoggingInterface.CommonLogging.Interfaces;
using Microsoft.Extensions.Logging;

namespace LoggingInterface.CommonLogging
{
    public sealed class LoggingOptionsFactory : ILoggingOptionsFactory
    {

        private readonly ILoggerFactory _LoggerFactory;
        public LoggingOptionsFactory(ILoggerFactory loggerFactory)
        {
            this._LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        public ILoggingOptions Create<T>() => new LoggingOptions(this._LoggerFactory, typeof(T));
        public ILoggingOptions Create() => new LoggingOptions(this._LoggerFactory);
        public ILoggingOptions Create(Type T) => new LoggingOptions(this._LoggerFactory, T);
        public ILoggingOptions Create(string fullName) => new LoggingOptions(this._LoggerFactory, fullName);

    }
}
