namespace notificationsApp.Interface
{
    public interface INotificationService
    {
        string ServiceName { get; }
        void Send(string message);
    }
}
