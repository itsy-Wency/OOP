using System;
using System.Linq;
namespace InheritanceEncapsulation;

public static class EncapsulationDemo
{
    public static void Run()
    {

        Console.WriteLine("ENCAPSULATION");

        Console.Write("Enter Ticket ID: ");
        string ticketId = Console.ReadLine() ?? "TCK-1002";
        Console.Write("Enter issue description: ");
        string description = Console.ReadLine() ?? "Unknown issue";
       
        ServiceTicket ticket = new ServiceTicket(ticketId,description);
        Console.WriteLine("\n--- Ticket Information ---");
        Console.WriteLine($"Ticket ID: {ticket.TicketId}");
        Console.WriteLine($"Description: {ticket.Description}");
        Console.WriteLine($"Current Status: {ticket.Status}");

        Console.WriteLine("\nAvailable statuses:");
        Console.WriteLine("1. Open");
        Console.WriteLine("2. In Progress");
        Console.WriteLine("3. Resolved");
        Console.Write("\nEnter new status: ");
        string newStatus = Console.ReadLine() ?? "Open";
       
        bool updated = ticket.UpdateStatus(newStatus);
        if (updated)
        {
            Console.WriteLine($"\nStatus successfully changed to: {ticket.Status}");
        }
        else
        {
            Console.WriteLine("\nInvalid status.");
            Console.WriteLine("The object rejected the change to protect its data.");
        }
    }
    
    public class ServiceTicket
    {

        private string _status;
        public string TicketId { get; private set; }
        public string Description { get; private set; }
        public string Status
        {
            get
            {
                return _status;
            }
        }
      
        public ServiceTicket(string ticketId,string description)
        {
            TicketId = ticketId;
            Description = description;
            _status = "Open";
        }
        
        public bool UpdateStatus(string newStatus)
        {
            string[] validStatuses = 
            {
                "Open",
                "In Progress",
                "Resolved"
            };

            if (!validStatuses.Contains(newStatus))
            {
                return false;
            }
            
            _status = newStatus;
            return true;
        }
    }
}

