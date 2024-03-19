namespace Assignment12.notification_senders
{
    public interface INotificationService
    {
        public NotificationType NotificationType { get; }

        void RegisterUser(User user);
        bool UserIsRegistered(User user);
        void SendNotification(User from, User to, NotificationContent content);
    }
}
