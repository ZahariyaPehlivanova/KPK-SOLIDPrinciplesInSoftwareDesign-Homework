using System;
using LoggerSOLID;
using LoggerSOLID.Interfaces;

namespace Logger.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format(string message, ReportLevel repLevel, DateTime date)
        {
            string logString = string.Format(
               "<log>\r\n" +
               "\t<date>{0}</date>{1}" +
               "\t<level>{2}</level>{1}" +
               "\t<message>{3}</message>\n" +
               "</log>",
               date,
               repLevel,
               message
               );

            return logString;
        }
    }
}
