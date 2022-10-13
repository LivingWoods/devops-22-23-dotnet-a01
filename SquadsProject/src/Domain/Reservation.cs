namespace Domain;

public class Reservation
{
    public Session Session { get; private set; }

	public Reservation(Session session)
	{
		Session = session;
	}
}
