namespace LoggerSOLID.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; set; }

        public ReportLevel Threshold { get; set; }

        public abstract void Append(string message, ReportLevel repLevel, DateTime date);
    }
}
