using System;

namespace LoggerSOLID.Interfaces
{
    public interface IAppender
    {
        ReportLevel Threshold { get; set; }

        ILayout Layout { get; set; }

        void Append(string message,ReportLevel repLevel,DateTime date);
    }
}
