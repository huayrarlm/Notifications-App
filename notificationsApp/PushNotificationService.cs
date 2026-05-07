using notificationsApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsApp
{
    internal class PushNotificationService : INotificationService
    {
        private readonly ILogger _logger;
        public string ServiceName => "Push";

        public PushNotificationService(ILogger logger) => _logger = logger;

        public void Send(string message)
        {
            _logger.Info($"[Push] Отправлено пуш-уведомление: {message}");
        }
    }
}
