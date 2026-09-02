namespace InheritanceEncapsulation;

public static class InterfaceDemo
{
    public static void Run()
    {

        Console.WriteLine("INTERFACE");
        Console.Write("Enter notification message: ");
        string message = Console.ReadLine() ?? "Your support ticket has been updated.";
        Console.WriteLine("\nChoose notification service:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        Console.Write("\nEnter choice: ");
        string choice = Console.ReadLine() ?? "1";

        INotificationService notificationService;
        if (choice == "2")
        {
            notificationService = new SmsNotification();
        }
        else
        {
            notificationService = new EmailNotification();
        }

        NotificationManager manager = new NotificationManager(notificationService);
       
        manager.Send(message);
    }

    public interface INotificationService
    {
        void Send(string message);
    }
    public class EmailNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("\nSending notification through EMAIL...");
            Console.WriteLine($"Email message: {message}");
            Console.WriteLine("Email notification sent successfully.");
        }
    }

    public class SmsNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("\nSending notification through SMS...");
            Console.WriteLine($"SMS message: {message}");
            Console.WriteLine("SMS notification sent successfully.");
        }
    }

    public class NotificationManager
    {
 
        private readonly INotificationService
        _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService =
            notificationService;
        }
        public void Send(string message)
        {
            _notificationService.Send(message);
        }
    }
}


