
using LoggingInterface.CommonLogging.Interfaces;
using Microsoft.Extensions.Logging;

namespace LoggingInterface.CommonLogging
{
    public sealed class LoggingOptions : ILoggingOptions

    {

        private readonly ILoggerFactory _LoggerFactory;
        private ILogger _logger;



        public LoggingOptions(ILoggerFactory loggerFactory)
        {
            this._LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
            this.GetLoggerManager<LoggingOptions>();
        }

        public LoggingOptions(ILoggerFactory loggerFactory, Type T)
        {
            this._LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
            this.GetLoggerManager(T);
        }


        public LoggingOptions(ILoggerFactory loggerFactory, string fullName)
        {
            this._LoggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
            this.GetLoggerManager(fullName);
        }

        public void Error(object message)
            => this._logger.LogError(message.ToString());

        public void Error(object message, Exception exception)
            => this._logger.LogError(exception, message.ToString());

        public void ErrorFormat(string format) => this._logger.LogError(format);

        public void ErrorFormat(string format, Exception exception)
            => this._logger.LogError(exception, format);
        public void ErrorFormat(string format, Exception exception, params object[] param)
            => this._logger.LogError(exception, format, param);

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] param)
         => this._logger.LogError(exception, format, param);


        public void Info(object message)
            => this._logger.LogInformation(message.ToString());

        public void Info(object message, Exception exception)
            => this._logger.LogInformation(exception, message.ToString());


        public void InfoFormat(string format)
            => this._logger.LogInformation(format);

        public void InfoFormat(string format, params object[] param)
            => this._logger.LogInformation(format, param);

        public void InfoFormat(string format, Exception exception, params object[] param)
                => this._logger.LogInformation(exception, format, param);

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] param)
            => this._logger.LogInformation(format, param);


        public void LogError(string message, Exception exception) => this._logger.LogError(exception, message);

        public void LogError(string message, Exception exception, params object[] args)
            => this._logger.LogError(exception, message, args);


        public void LogWarning(string message)
            => this._logger.LogWarning(message);

        public void LogWarning(string message, Exception exception)
            => this._logger.LogWarning(exception, message);

        public void LogWarning(string message, Exception exception, params object[] args)
            => this._logger.LogWarning(exception, message, args);

        public void Trace(string message)
        {
            this._logger.LogTrace(message);
        }

        public void Trace(string message, params object[] args)
        {
            this._logger.LogTrace(message, args);
        }

        public void Warn(object message)
        {
            this._logger.LogWarning(message.ToString());
        }

        public void Warn(object message, Exception exception)
        {
            this._logger.LogWarning(exception, message.ToString());
        }

        public void Warn(object message, Exception exception, params object[] param)
        {
            this._logger.LogWarning(exception, message.ToString(), param);
        }

        public void WarnFormat(string format)
        {
            this._logger.LogWarning(format);
        }

        public void WarnFormat(string format, Exception exception)
        {
            this._logger.LogWarning(exception, format);
        }

        public void WarnFormat(string format, Exception exception, params object[] param)
        {
            this._logger.LogWarning(exception, format, param);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] param)
        {
            this._logger.LogWarning(exception, format, param);
        }

        private ILoggingOptions GetLoggerManager<T>()
        {
            this._logger = this._LoggerFactory.CreateLogger<T>();
            return this;
        }
        private ILoggingOptions GetLoggerManager(Type t)
        {
            this._logger = this._LoggerFactory.CreateLogger(t);
            return this;
        }
        private ILoggingOptions GetLoggerManager(string fullName)
        {
            this._logger = this._LoggerFactory.CreateLogger(fullName);
            return this;
        }
    }
}
