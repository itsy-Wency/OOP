using System;
namespace InheritanceEncapsulation;

public static class AccessModifier
{
    public static void Run()
    {
        Console.WriteLine("Access Modifier Example");
        Console.WriteLine("\nCreating a support ticket...");

        Console.WriteLine("Enter Ticket ID:");
        string? ticketIdInput = Console.ReadLine();
        string ticketId = string.IsNullOrEmpty(ticketIdInput) ? "No ticket ID provided" : ticketIdInput;

        Console.Write("Enter Ticket Description: ");
        string? descriptionInput = Console.ReadLine();
        string description = string.IsNullOrEmpty(descriptionInput) ? "Default Description" : descriptionInput;

        SupportTicket ticket = new SupportTicket(ticketId, description);
        Console.WriteLine($"\nPublic Ticket ID: {ticket.TicketId}");
        Console.WriteLine($"\nInternal Category: {ticket.Category}");
        Console.WriteLine($"Description: {ticket.GetDescription()}");
        Console.WriteLine("\nAccess modifier demonstration complete.");

    }

    public class SupportTicket
    {
        public string TicketId {get;}
        private string Description {get;}
        internal string Category {get; set;}

        public SupportTicket(string ticketId, string description)
        {
            TicketId = ticketId;
            Description = description;
            Category = "General";
        }

        public string GetDescription()
        {
            return Description;

        }
    }
}
