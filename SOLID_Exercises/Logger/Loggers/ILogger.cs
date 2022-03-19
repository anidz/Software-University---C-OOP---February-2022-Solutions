using Logger.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Loggers
{
    public interface ILogger
    {
        IAppender[] Appenders { get; }

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Fatal(string message);

        void Critical(string message);
    }
}
