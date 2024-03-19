using Assignment12.notification_senders;

namespace Assignment12
{
    public class NotificationServiceManager : INotificationServiceManager
    {
        protected readonly Dictionary<NotificationType, INotificationService> _registeredNotificationServices = [];

        public void RegisterNotificationService(INotificationService notificationService)
        {
            if (_registeredNotificationServices.ContainsKey(notificationService.NotificationType))
            {
                Console.WriteLine($"{notificationService.NotificationType} notification service is already registered!");
                return;
            }

            _registeredNotificationServices.Add(notificationService.NotificationType, notificationService);
            Console.WriteLine($"{notificationService.NotificationType} notification service was registered!");
        }

        public void RegisterUserToNotificationService(NotificationType notificationType, User user)
        {
            if (!_registeredNotificationServices.ContainsKey(notificationType))
            {
                Console.WriteLine($"{notificationType} notification service is not registered!");
                return;
            }

            _registeredNotificationServices[notificationType].RegisterUser(user);
        }

        public bool UserIsRegisteredToNotificationService(NotificationType notificationType, User user)
        {
            if (!_registeredNotificationServices.ContainsKey(notificationType))
            {
                Console.WriteLine($"{notificationType} notification service is not registered!");
                return false;
            }

            return _registeredNotificationServices[notificationType].UserIsRegistered(user);
        }

        public void SendNotificationFromUserToUser(NotificationType notificationType, User from, User to, NotificationContent content)
        {
            if (!_registeredNotificationServices.ContainsKey(notificationType))
            {
                Console.WriteLine($"{notificationType} notification service is not registered!");
                return;
            }

            if (!UserIsRegisteredToNotificationService(notificationType, from)
                || !UserIsRegisteredToNotificationService(notificationType, to))
                return;

            INotificationService notificationService = _registeredNotificationServices[notificationType];
            notificationService.SendNotification(from, to, content);
        }

        public void ReceiveNotificationFromUser(NotificationType notificationType, User from, User to, NotificationContent content)
        {
            Console.WriteLine($"User {to.Name} received {notificationType} notification from user {from.Name}!");
        }
    }
}
