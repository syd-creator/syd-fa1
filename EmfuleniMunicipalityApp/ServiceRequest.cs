public class ServiceRequest
{
    public string RequestType { get; set; }
    public int Priority { get; set; }   // 1 to 5
    public int Severity { get; set; }   // 1 to 10
    public int EstimatedHours { get; set; }

    public Resident Resident { get; set; }
    public double UrgencyScore { get; set; }

    public ServiceRequest(Resident resident, string requestType, int priority, int severity, int estimatedHours)
    {
        Resident = resident;
        RequestType = requestType;
        Priority = priority;
        Severity = severity;
        EstimatedHours = estimatedHours;

        UrgencyScore = (priority * 2) + (severity * 3) + (estimatedHours);
    }
}