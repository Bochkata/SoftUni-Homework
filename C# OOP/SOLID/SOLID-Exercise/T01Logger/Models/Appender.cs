
namespace T01Logger
{
   public abstract class Appender: IAppender
    {
        protected Appender(ILayout layout)
        {
            Layout = layout;
        }
        
        public ILayout Layout { get; }
        public int Count { get;  protected set; }

        public LogLevel_Enums ReportLevel { get; set; }

        public virtual void Append(string dateTime, LogLevel_Enums reportLevel, string message)
        {
            
        }

        public virtual string GetAppenderInfo() => $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {Count}";
        
    }
}
