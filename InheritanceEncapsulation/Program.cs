namespace InheritanceEncapsulation;

 class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Simple IT Ticketing System");

       while (true)
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Access Modifier");
            Console.WriteLine("2. Properties");
            Console.WriteLine("3. Encapsulation and Validation");
            Console.WriteLine("4. Inheritance");
            Console.WriteLine("5. Abstract Class");
            Console.WriteLine("6. Interface");
            Console.WriteLine("7. Exit");
            Console.Write("\nChoice: ");
            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AccessModifier.Run();
                    break;
                // case "2":
                //     Properties.Run();
                //     break;
                // case "3":
                //     Encapsulation.Run();
                //     break;
                // case "4":
                //     InheritanceEncapsulation.Run();
                //     break;
                // case "5":
                //     Abstraction.Run();
                //     break;
                // case "6":
                //     Interface.Run();
                //     break;
                case "0":
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\n Press ENTER to continue...");
            Console.ReadLine();

        }
    }
}