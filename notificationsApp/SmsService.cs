using notificationsApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsApp
{
    internal class SmsService : INotificationService
    {   
        public readonly ILogger _logger;
        public string ServiceName => "SMS";
        public SmsService(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(string message)
        {
            // Имитация случайного сбоя 
            if (new Random().Next(0, 2) == 0)
            {
                throw new Exception("Ошибка сети при отправке SMS!");
            }

            _logger.Info($"[SMS] Доставлено: {message}");
        }
    }
}
