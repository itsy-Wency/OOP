namespace InheritanceEncapsulation;

public static class AbstractionDemo
{
    public static void Run()
    {

        Console.WriteLine("ABSTRACTION");

        Console.Write("Enter device name: ");
        string deviceName = Console.ReadLine() ?? "Office Laptop";
        Console.Write("Enter IP address: ");
        string ipAddress = Console.ReadLine() ?? "192.168.1.10";

        NetworkDevice device = new Laptop(deviceName,ipAddress);
        Console.WriteLine("\n--- Device Information ---");

        device.DisplayDevice();
        Console.WriteLine("\n--- Connection ---");

        device.Connect();
        Console.WriteLine("\n--- Health Check ---");

        device.PerformHealthCheck();
    }

    public abstract class NetworkDevice
    {
        protected string DeviceName { get; }
        protected string IpAddress { get; }
        protected NetworkDevice(string deviceName,string ipAddress)
        {
            DeviceName = deviceName;
            IpAddress = ipAddress;
        }
        public abstract void Connect();

        public void DisplayDevice()
        {
            Console.WriteLine(
            $"Device Name: {DeviceName}"
            );
            Console.WriteLine(
            $"IP Address: {IpAddress}"
            );
        }

        public void PerformHealthCheck()
        {
            Console.WriteLine( "Checking device availability...");
            Console.WriteLine("Checking network connectivity...");
            Console.WriteLine("Checking device response...");
            Console.WriteLine("Health check completed successfully.");
        }
    }

    public class Laptop : NetworkDevice
    {
        public Laptop(string deviceName,string ipAddress) : base(deviceName,ipAddress)
        {
        }
       
        public override void Connect()
        {
            Console.WriteLine($"Laptop '{DeviceName}' connected to the network.");
        }
    }
}
