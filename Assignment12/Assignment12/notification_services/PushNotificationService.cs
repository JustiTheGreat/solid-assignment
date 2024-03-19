namespace Assignment12.notification_senders
{
    public class PushNotificationService : BaseNotificationService
    {
        public static PushNotificationService Instance { get; } = new PushNotificationService();

        private PushNotificationService() : base(NotificationType.PUSH) { }

        public override void SendNotification(User from, User to, NotificationContent content)
        {
            if (!UserIsRegistered(from) || !UserIsRegistered(to))
                return;

            Console.WriteLine($"{NotificationType} notification from user {from.Name} was sent to user {to.Name}!");
        }
    }
}
