
using System;
using System.IO;

namespace T01Logger
{
   public class FileAppender : Appender
   {
       private const string FilePath = @"../../../result.txt";
        public FileAppender(ILayout layout, ILogFile logFile): base(layout)
        {
            LogFile = logFile;

        }
        public ILogFile LogFile { get; }
      
        public override void Append(string dateTime, LogLevel_Enums reportLevel, string message)
        {
            string msg = string.Format(Layout.Format, dateTime, reportLevel, message);
            Count++;
            LogFile.Write(msg);
            File.AppendAllText(FilePath,msg + Environment.NewLine);
        }
        public override string GetAppenderInfo() => $"{base.GetAppenderInfo()}, File Size: {LogFile.Size}";
    }
}
