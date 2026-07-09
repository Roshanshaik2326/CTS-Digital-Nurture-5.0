using System;

// Subject
public interface IDocument
{
    void AccessDocument();
}

// Real Subject
public class ConfidentialDocument : IDocument
{
    public void AccessDocument()
    {
        Console.WriteLine("Access Granted: Confidential Document Opened.");
    }
}

// Proxy
public class DocumentProxy : IDocument
{
    private readonly bool isAuthorized;
    private ConfidentialDocument? document;

    public DocumentProxy(bool isAuthorized)
    {
        this.isAuthorized = isAuthorized;
    }

    public void AccessDocument()
    {
        if (!isAuthorized)
        {
            Console.WriteLine("Access Denied! You are not authorized.");
            return;
        }

        document ??= new ConfidentialDocument();
        document.AccessDocument();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Proxy Pattern ===\n");

        Console.WriteLine("Unauthorized User:");
        IDocument user1 = new DocumentProxy(false);
        user1.AccessDocument();

        Console.WriteLine();

        Console.WriteLine("Authorized User:");
        IDocument user2 = new DocumentProxy(true);
        user2.AccessDocument();
    }
}