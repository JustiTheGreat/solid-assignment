namespace Assignment12.notification_senders
{
    public class SMSNotificationService : BaseNotificationService
    {
        public static SMSNotificationService Instance { get; } = new SMSNotificationService();

        public SMSNotificationService() : base(NotificationType.SMS) { }

        public override void SendNotification(User from, User to, NotificationContent content)
        {
            if (!UserIsRegistered(from) || !UserIsRegistered(to))
                return;

            Console.WriteLine($"{NotificationType} notification from user {from.Name} was sent to user {to.Name}!");
        }
    }
}
