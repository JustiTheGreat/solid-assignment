namespace Assignment12.notification_senders
{
    public class EmailNotificationService : BaseNotificationService
    {
        public static EmailNotificationService Instance { get; } = new EmailNotificationService();

        private EmailNotificationService() : base(NotificationType.EMAIL) { }

        public override void SendNotification(User from, User to, NotificationContent content)
        {
            if (!UserIsRegistered(from) || !UserIsRegistered(to))
                return;

            Console.WriteLine($"{NotificationType} notification from user {from.Name} was sent to user {to.Name}!");
        }
    }
}
