namespace LoggerSOLID.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(string message, ReportLevel repLevel, DateTime date)
        {
            return string.Format("{0} - {1} - {2}", date, repLevel, message);
        }
    }
}
