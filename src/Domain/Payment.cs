namespace Squads.Domain;

public class Payment
{
    public DateTime PaidOn { get; }

	public Payment()
	{
		PaidOn = DateTime.UtcNow;
	}
}
