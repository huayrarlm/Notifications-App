using notificationsApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsApp
{
    internal class NotificationSender
    {
        private readonly INotificationService _notificationService;

        public NotificationSender(INotificationService service)
        {
            _notificationService = service;
        }

        public void SendNotification(string message)
        {
            _notificationService.Send(message);
        }
    }
}
