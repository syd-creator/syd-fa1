using System;

class Program
{
    static void Main(string[] args)
    {
        UtilitiesManager manager = new UtilitiesManager();

        Console.Write("How many residents? ");
        int residentCount = int.Parse(Console.ReadLine());

        Resident[] residents = new Resident[residentCount];

        // Capture residents
        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"\nResident {i + 1}");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents[i] = new Resident(name, address, acc, usage);
        }

        // Service requests
        Console.Write("\nHow many service requests? ");
        int requestCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < requestCount; i++)
        {
            Console.WriteLine($"\nRequest {i + 1}");

            Console.Write("Select resident index (0 - " + (residentCount - 1) + "): ");
            int resIndex = int.Parse(Console.ReadLine());

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Hours: ");
            int hours = int.Parse(Console.ReadLine());

            ServiceRequest request = new ServiceRequest(residents[resIndex], type, priority, severity, hours);

            manager.AddRequest(request);
        }

        // Display queue
        manager.DisplayQueue();

        // Process requests
        Console.WriteLine("\nProcessing requests...\n");

        foreach (var r in manager.Requests)
        {
            Console.WriteLine($"Processing {r.RequestType} for {r.Resident.Name}");
            Console.WriteLine($"Urgency Score: {r.UrgencyScore}");
            Console.WriteLine("Status: COMPLETED\n");
        }

        // Summary
        Console.WriteLine("\n--- SUMMARY ---");

        Console.WriteLine("Highest Urgency Request:");
        var highest = manager.GetHighestUrgency();

        Console.WriteLine($"Resident: {highest.Resident.Name}");
        Console.WriteLine($"Type: {highest.RequestType}");
        Console.WriteLine($"Urgency: {highest.UrgencyScore}");

        Console.ReadLine();
    }
}