using Assignment12.notification_senders;

namespace Assignment12
{
    public interface INotificationServiceManager
    {
        public void RegisterNotificationService(INotificationService notificationService);

        public void RegisterUserToNotificationService(NotificationType notificationType, User user);

        public bool UserIsRegisteredToNotificationService(NotificationType notificationType, User user);

        public void SendNotificationFromUserToUser(NotificationType notificationType, User from, User to, NotificationContent content);

        public void ReceiveNotificationFromUser(NotificationType notificationType, User from, User to, NotificationContent content);
    }
}
