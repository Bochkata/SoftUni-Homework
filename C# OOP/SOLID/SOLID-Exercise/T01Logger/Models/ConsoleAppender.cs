

using System;

namespace T01Logger
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
          
        }
       
        public override void Append(string dateTime, LogLevel_Enums reportLevel, string message)
        {
            Count++;
            string msgToAppend = string.Format(Layout.Format, dateTime, reportLevel, message);
            Console.WriteLine(msgToAppend);
        }
      
    }
}
