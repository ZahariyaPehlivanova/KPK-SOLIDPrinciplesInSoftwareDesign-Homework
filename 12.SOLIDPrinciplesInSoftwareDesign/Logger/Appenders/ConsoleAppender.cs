namespace LoggerSOLID.Appenders
{
    using LoggerSOLID.Interfaces;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
        }

        public override void Append(string message, ReportLevel repLevel, DateTime date)
        {
            if (this.Threshold <= repLevel)
            {
                var formattedMessage = this.Layout.Format(message, repLevel, date);
                Console.WriteLine(formattedMessage);
            }
        }
    }
}
