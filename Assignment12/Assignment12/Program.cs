using Assignment12;
using Assignment12.notification_senders;

INotificationService emailNotificationService = EmailNotificationService.Instance;
INotificationService pushNotificationService = PushNotificationService.Instance;
INotificationService smsNotificationService = SMSNotificationService.Instance;

INotificationServiceManager notificationServiceManager = new NotificationServiceManager();
notificationServiceManager.RegisterNotificationService(emailNotificationService);
notificationServiceManager.RegisterNotificationService(pushNotificationService);
notificationServiceManager.RegisterNotificationService(smsNotificationService);

User u1 = new("user1");
User u2 = new("user2");

notificationServiceManager.RegisterUserToNotificationService(NotificationType.EMAIL, u1);
notificationServiceManager.RegisterUserToNotificationService(NotificationType.PUSH, u1);
notificationServiceManager.RegisterUserToNotificationService(NotificationType.SMS, u1);
notificationServiceManager.RegisterUserToNotificationService(NotificationType.EMAIL, u2);

NotificationContent greeting = new("Greeting", "Hello!");

notificationServiceManager.SendNotificationFromUserToUser(NotificationType.EMAIL, u1, u2, greeting);
notificationServiceManager.SendNotificationFromUserToUser(NotificationType.SMS, u1, u2, greeting);

