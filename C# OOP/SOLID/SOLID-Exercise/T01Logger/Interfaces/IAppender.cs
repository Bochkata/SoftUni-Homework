
namespace T01Logger
{
    public interface IAppender
    {
        public ILayout Layout { get; }
        public int Count { get; }
        public LogLevel_Enums ReportLevel { get; set; }
        void Append(string dateTime, LogLevel_Enums reportLevel, string message);
        string GetAppenderInfo();

    }
}
