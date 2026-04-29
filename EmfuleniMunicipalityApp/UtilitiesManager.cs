using System;
using System.Collections.Generic;

public class UtilitiesManager
{
    public List<ServiceRequest> Requests = new List<ServiceRequest>();

    public void AddRequest(ServiceRequest request)
    {
        Requests.Add(request);
    }

    public void DisplayQueue()
    {
        Console.WriteLine("\n--- Service Request Queue ---");

        foreach (var r in Requests)
        {
            Console.WriteLine($"Type: {r.RequestType} | Resident: {r.Resident.Name} | Urgency: {r.UrgencyScore}");
        }
    }

    public ServiceRequest GetHighestUrgency()
    {
        ServiceRequest highest = Requests[0];

        foreach (var r in Requests)
        {
            if (r.UrgencyScore > highest.UrgencyScore)
            {
                highest = r;
            }
        }

        return highest;
    }
}