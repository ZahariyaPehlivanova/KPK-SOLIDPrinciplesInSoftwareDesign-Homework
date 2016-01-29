﻿namespace LoggerConsoleApplication
{
    using Logger.Appenders;
    using Logger.Layouts;
    using LoggerSOLID;
    using LoggerSOLID.Appenders;
    using LoggerSOLID.Layouts;
    using LoggerSOLID.Logers;

    class Program
    {
        static void Main()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);

            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "log.txt";

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");

        }
    }
}
