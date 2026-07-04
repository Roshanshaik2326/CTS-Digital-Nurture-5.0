using System;

// Abstraction
public interface IMessageService
{
    void Send();
}

// Low-level module
public class EmailService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("Email Sent.");
    }
}

// Another low-level module
public class SmsService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("SMS Sent.");
    }
}

// High-level module
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify()
    {
        _messageService.Send();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageService email = new EmailService();
        Notification notification = new Notification(email);

        notification.Notify();

        IMessageService sms = new SmsService();
        Notification smsNotification = new Notification(sms);

        smsNotification.Notify();
    }
}