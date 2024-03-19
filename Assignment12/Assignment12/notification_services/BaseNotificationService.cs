namespace Assignment12.notification_senders
{
    public abstract class BaseNotificationService(NotificationType notificationType) : INotificationService
    {
        public NotificationType NotificationType { get; } = notificationType;
        protected readonly List<User> _registeredUsers = [];

        public void RegisterUser(User user)
        {
            if (_registeredUsers.Contains(user))
            {
                Console.WriteLine($"User {user.Name} is already registered to {NotificationType} notification service!");
            }
            else
            {
                _registeredUsers.Add(user);
                Console.WriteLine($"User {user.Name} was registered to {NotificationType} notification service!");
            }
        }

        public bool UserIsRegistered(User user)
        {
            if (!_registeredUsers.Contains(user))
            {
                Console.WriteLine($"User {user.Name} is not registered to the {NotificationType} notification service!");
                return false;
            }

            return true;
        }

        public abstract void SendNotification(User from, User to, NotificationContent content);
    }
}
