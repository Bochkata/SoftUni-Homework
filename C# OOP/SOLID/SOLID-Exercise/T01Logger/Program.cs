
using System;
using System.Linq;

namespace T01Logger
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //ILayout simpleLayout = new SimpleLayout();
            //IAppender consoleAppender =
            //    new ConsoleAppender(simpleLayout);
            //IAppender fileAppender = new FileAppender(simpleLayout);
            //ILogger logger = new Logger(consoleAppender);
            //ILogger fileLogger = new Logger(fileAppender);

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
            //fileLogger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //fileLogger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);


            //LogFile file = new LogFile();

            //FileAppender fileAppender = new FileAppender(simpleLayout, file);
            //consoleAppender.ReportLevel = LogLevel_Enums.Error;
            //fileAppender.ReportLevel = LogLevel_Enums.Error;

            //Logger logger = new Logger(consoleAppender);
            //Logger logger1 = new Logger(fileAppender);

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
            //logger1.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger1.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
            //logger.Error("3/31/2015 5:33:07 PM","Error parsing request");
            //logger1.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            //XmlLayout xmlLayout = new XmlLayout();
            //ConsoleAppender consoleAppender = new ConsoleAppender(xmlLayout);
            //Logger logger = new Logger(consoleAppender);

            //logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            //logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.ReportLevel = LogLevel_Enums.Error;

            //var logger = new Logger(consoleAppender);

            //logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            //logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            //logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            //logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            //logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");
            //Console.WriteLine(file.Size);

            int num = int.Parse(Console.ReadLine());
            LayoutCreator layoutCreator = new LayoutCreator();
            AppenderCreator appenderCreator = new AppenderCreator();
            ILogger logger = new Logger();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string appenderType = input[0];
                string layoutType = input[1];
                ILayout layout = layoutCreator.CreateLayout(layoutType);
                IAppender appender = appenderCreator.CreateAppender(appenderType, layout);

                if (input.Length == 3)
                {
                    bool hasReportLevel = Enum.TryParse(input[2], true, out LogLevel_Enums reportlevel);

                    if (hasReportLevel)
                    {
                        appender.ReportLevel = reportlevel;
                    }
                }

                logger.Appenders.Add(appender);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split("|");

                //	"<REPORT LEVEL>|<time>|<message>"

                string reportLevel = tokens[0];
                string dateTime = tokens[1];
                string message = tokens[2];
                if (Enum.TryParse(reportLevel, true, out LogLevel_Enums repLevel))
                {
                    if (repLevel == LogLevel_Enums.INFO)
                    {
                        logger.Info(dateTime, message);
                    }
                    else if (repLevel == LogLevel_Enums.WARNING)
                    {
                        logger.Warning(dateTime, message);
                    }
                    else if (repLevel == LogLevel_Enums.ERROR)
                    {
                        logger.Error(dateTime, message);
                    }
                    else if (repLevel == LogLevel_Enums.CRITICAL)
                    {
                        logger.Critical(dateTime, message);
                    }
                    else 
                    {
                        logger.Fatal(dateTime, message);
                    }
                }

            }

            Console.WriteLine("Logger info");
            Console.WriteLine(logger.GetLoggerInfo());

        }

    }
}
