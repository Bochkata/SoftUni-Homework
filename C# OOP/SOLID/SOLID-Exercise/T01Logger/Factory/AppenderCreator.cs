

using System;

namespace T01Logger
{
    public class AppenderCreator
    {
        public Appender CreateAppender(string appenderType, ILayout layout)
        {
            Appender appender = null;
            LogFile logFile = new LogFile();
            if (appenderType == nameof(ConsoleAppender))
            {
                appender = new ConsoleAppender(layout);
            }
            else if (appenderType == nameof(FileAppender))
            {
                appender = new FileAppender(layout, logFile);
            }
            else
            {
                throw new ArgumentException("Invalid appender!");
            }

            return appender;
        }
        
    }
}
