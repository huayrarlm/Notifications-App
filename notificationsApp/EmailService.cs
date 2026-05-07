using notificationsApp.Interface;

namespace notificationsApp
{
    internal class EmailService : INotificationService
    {
        private readonly ILogger _logger;
        public string ServiceName => "Email";


        public EmailService(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(string message)
        {
            _logger.Info($"[Email] Сообщение отправлено: {message}");
        }

    }
}
