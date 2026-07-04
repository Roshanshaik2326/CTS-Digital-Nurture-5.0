using System;

// Interface
public interface IMessageService
{
    void SendMessage();
}

// Email Service
public class EmailService : IMessageService
{
    public void SendMessage()
    {
        Console.WriteLine("Email sent successfully.");
    }
}

// SMS Service
public class SmsService : IMessageService
{
    public void SendMessage()
    {
        Console.WriteLine("SMS sent successfully.");
    }
}

// Consumer Class
public class NotificationManager
{
    private readonly IMessageService _messageService;

    // Constructor Injection
    public NotificationManager(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify()
    {
        _messageService.SendMessage();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageService email = new EmailService();

        NotificationManager manager = new NotificationManager(email);

        manager.Notify();

        Console.WriteLine();

        IMessageService sms = new SmsService();

        NotificationManager manager2 = new NotificationManager(sms);

        manager2.Notify();
    }
}