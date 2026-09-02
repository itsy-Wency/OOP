namespace InheritanceEncapsulation;

public static class PropertiesDemo
{
    public static void Run()
    {

        Console.WriteLine("PROPERTIES");

        Console.Write("Enter employee name: ");
        string name = Console.ReadLine() ?? "Unknown Employee";
        Console.Write("Enter department: ");
        string department = Console.ReadLine() ?? "IT Department";
       
        Employee employee = new Employee(name, department);
        Console.WriteLine("\n--- Employee Information ---");
        
        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Department: {employee.Department}");

        Console.Write("\nEnter new department: ");
        string newDepartment =Console.ReadLine() ?? department;
        employee.Department = newDepartment;
        
        Console.WriteLine("\n--- Updated Information ---");
        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Department: {employee.Department}");
    }

    public class Employee
    {

        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(string name,string department)
        {
            Name = name;
            Department = department;
        }
    }
}
