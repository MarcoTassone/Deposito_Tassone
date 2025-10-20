using Lezione20_10_Architetture.Dependency_Injection;

namespace Lezione20_10_Architetture.Dependency_Injection
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log:  {message}");

        }
    }

    public class UserService
    {
        private readonly ILogger _logger;

        public UserService(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateUser(string name)
        {
            _logger.Log($"User: {name} created.");
        }
    }
}