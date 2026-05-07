using notificationsApp.Interface;

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
