using LoggerSOLID.Interfaces;
using System;
using System.Collections.Generic;

namespace LoggerSOLID.Logers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public IList<IAppender> Appenders { get; private set; }

        public void Critical(string message)
        {
            this.Log(message,ReportLevel.Critical);
        }

        public void Error(string message)
        {
            this.Log(message,ReportLevel.Error);
        }

        public void Fatal(string message)
        {
            this.Log(message,ReportLevel.Fatal);
        }

        public void Info(string message)
        {
            this.Log(message,ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Log(message,ReportLevel.Warn);
        }

        private void Log(string message,ReportLevel reportLevel)
        {
            var date = DateTime.Now;
            foreach (var appender in this.Appenders)
            {
                appender.Append(message,reportLevel,date);
            }
        }
    }
}
