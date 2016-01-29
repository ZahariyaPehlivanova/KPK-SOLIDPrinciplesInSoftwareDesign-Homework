using System;

namespace LoggerSOLID.Interfaces
{
    public interface ILayout
    {
        string Format(string message, ReportLevel repLevel, DateTime date);
    }
}
