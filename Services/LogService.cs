using System.Diagnostics;

namespace MonWebApp.Services
{
    public class LogService : ILogService
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
