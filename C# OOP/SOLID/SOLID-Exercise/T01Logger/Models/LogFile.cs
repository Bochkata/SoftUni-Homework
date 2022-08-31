

using System.Linq;

using System.Text;

namespace T01Logger
{
    public class LogFile: ILogFile
    {
        private StringBuilder sb;
        public LogFile()
        {
            sb = new StringBuilder();
        }
        
        public int Size => sb.ToString().Where(x => char.IsLetter(x)).Sum(x=>x);
        public void Write(string message)
        {
            sb.Append(message);
        }
    }
}
