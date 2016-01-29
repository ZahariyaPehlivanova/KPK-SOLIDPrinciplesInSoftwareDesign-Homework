namespace LoggerSOLID.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        IList<IAppender> Appenders { get; }

        void Error(string message);

        void Info(string message);

        void Warn(string message);

        void Fatal(string message);

        void Critical(string message);

    }
}
