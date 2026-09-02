namespace InheritanceEncapsulation;

public static class InheritanceEncapsulationDemo
{
    public static void Run()
    {

        Console.WriteLine("ENCAPSULATION + INHERITANCE");

        Console.Write("Enter technician name: ");
        string technicianName = Console.ReadLine() ?? "Technician";
        Console.Write("Enter Ticket ID: ");
        string ticketId = Console.ReadLine() ?? "TCK-1003";

        NetworkTechnician technician = new NetworkTechnician(technicianName,ticketId);
        Console.WriteLine("\n--- Ticket Assignment ---");
        technician.DisplayTicketInfo();
        Console.WriteLine("\n--- Diagnosis ---");
        technician.StartDiagnosis();
    }

    public class SupportStaff
    {

        private readonly string _ticketId;
        protected string TechnicianName
        {
            get;
            private set;
        }

        public SupportStaff(string technicianName,string ticketId)
        {
            TechnicianName = technicianName;
            _ticketId = ticketId;
        }
        public void DisplayTicketInfo()
        {
            Console.WriteLine($"Technician: {TechnicianName}");
            Console.WriteLine($"Ticket ID: {_ticketId}");
        }

        protected string GetTicketId()
        {
            return _ticketId;
        }
    }

    public class NetworkTechnician : SupportStaff
    {

        public NetworkTechnician(string technicianName, string ticketId): base(technicianName,ticketId)
        {
        }
        public void StartDiagnosis()
        {

            Console.WriteLine($"Technician {TechnicianName} is starting diagnosis.");

            string ticketId = GetTicketId();
            Console.WriteLine($"Diagnosing ticket: {ticketId}");
            Console.WriteLine("Checking network connectivity...");
            Console.WriteLine("Checking IP configuration...");
            Console.WriteLine("Checking DNS configuration...");
            Console.WriteLine("Diagnosis process completed.");
        }
    }
}
