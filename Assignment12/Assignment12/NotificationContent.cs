namespace Assignment12
{
    public class NotificationContent(string title, string body)
    {
        public string Title { get; set; } = title;
        public string Body { get; set; } = body;
    }
}
