

using System.Collections.Generic;
using System.Text;

namespace T01Logger
{
    public class Logger: ILogger
    {
        public Logger(params IAppender []appender)
        {
            Appenders = new List<IAppender>(appender);
            //Appenders.AddRange(appender);
        }

        public List<IAppender> Appenders { get; }
        public void Info(string dateTime, string message)
        {
            Log(dateTime, LogLevel_Enums.INFO, message);
        }

        public void Warning(string dateTime, string message)
        {
            Log(dateTime, LogLevel_Enums.WARNING, message);
        }

        public void Error(string dateTime, string message)
        {
            Log(dateTime, LogLevel_Enums.ERROR, message);
        }

        public void Critical(string dateTime, string message)
        {
            Log(dateTime, LogLevel_Enums.CRITICAL, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Log(dateTime, LogLevel_Enums.FATAL, message);
        }

        public string GetLoggerInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IAppender appender in Appenders)
            {
                sb.AppendLine(appender.GetAppenderInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public void Log(string dateTime, LogLevel_Enums logLevel, string message)
        {
            foreach (var appender in Appenders)
            {
                if (logLevel >= appender.ReportLevel)
                {
                    appender.Append(dateTime, logLevel, message);
                }
            }
        }
    }
}
