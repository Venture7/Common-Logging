using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterface.CommonLogging.Interfaces
{
    public interface ILoggingOptionsFactory
    {
        ILoggingOptions Create<T>();
        ILoggingOptions Create();
        ILoggingOptions Create(Type T);
        ILoggingOptions Create(string fullName);
    }
}
