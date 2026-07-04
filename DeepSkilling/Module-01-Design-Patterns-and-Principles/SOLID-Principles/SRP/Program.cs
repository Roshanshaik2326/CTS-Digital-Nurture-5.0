using System;

public class Invoice
{
    public decimal CalculateTotal(decimal price, int quantity)
    {
        return price * quantity;
    }
}

public class InvoiceRepository
{
    public void SaveInvoice()
    {
        Console.WriteLine("Invoice saved to database.");
    }
}

public class InvoicePrinter
{
    public void PrintInvoice()
    {
        Console.WriteLine("Invoice printed successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice();

        decimal total = invoice.CalculateTotal(500, 2);

        Console.WriteLine($"Total Amount: {total}");

        InvoiceRepository repository = new InvoiceRepository();
        repository.SaveInvoice();

        InvoicePrinter printer = new InvoicePrinter();
        printer.PrintInvoice();
    }
}