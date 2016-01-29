namespace Logger.Appenders
{
    using LoggerSOLID.Appenders;
    using System;
    using LoggerSOLID.Interfaces;
    using LoggerSOLID;
    public class FileAppender : Appender
    {
        private string outputFile;

        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File
        {
            get
            {
                return this.outputFile;
            }
            set
            {
                this.ValidateFilePath(value);
                this.outputFile = value;
            }
        }

        public override void Append(string message, ReportLevel repLevel, DateTime date)
        {
            this.CheckIfFilePathIsSet();

            this.WriteMessageToFile(message);
        }

        private void ValidateFilePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("The file path cannot be null ot empty!");
            }
        }

        private void CheckIfFilePathIsSet()
        {
            if (this.File == null)
            {
                throw new ArgumentNullException("The file path is not set correctly!");
            }
        }

        private void WriteMessageToFile(string message)
        {
            string path = this.File;
            string messageToFile = message + Environment.NewLine;
            System.IO.File.AppendAllText(path, messageToFile);
        }
    }
}
