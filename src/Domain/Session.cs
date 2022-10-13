namespace Domain;

public class Session
{
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public SessionType SessionType { get; private set; }
}
