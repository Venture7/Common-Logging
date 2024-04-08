using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterface.CommonLogging.Interfaces
{
    public interface ILoggingOptions
    {
        void LogError(string message, Exception exception);
        void LogError(string message, Exception exception, params object[] args);

        void LogWarning(string message);
        void LogWarning(string message, Exception exception);
        void LogWarning(string message, Exception exception, params object[] args);

        void Trace(string message);
        void Trace(string message, params object[] args);
        void Info(object message);
        void Info(object message, Exception exception);

        void InfoFormat(string format);
        void InfoFormat(string format, params object[] param);
        void InfoFormat(string format, Exception exception, params object[] param);
        void InfoFormat(IFormatProvider formatProvider, string format, params object[] param);

        void Warn(object message);
        void Warn(object message, Exception exception);
        void Warn(object message, Exception exception, params object[] param);
        void WarnFormat(string format);
        void WarnFormat(string format, Exception exception);
        void WarnFormat(string format, Exception exception, params object[] param);
        void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] param);
        void Error(object message);
        void Error(object message, Exception exception);
        void ErrorFormat(string format);
        void ErrorFormat(string format, Exception exception);
        void ErrorFormat(string format, Exception exception, params object[] param);
        void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] param);
    }
}
