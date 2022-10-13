namespace Domain;

public class Subscription
{
    public DateTime ValidFrom { get; private set; }
    public DateTime ValidTill { get; private set; }
    public Payment? Payment { get; private set; }
    public bool IsCanceled { get; private set; }

    public Subscription(DateTime validFrom, DateTime validTill, Payment? payment, bool isCanceled)
    {
        ValidFrom = validFrom;
        ValidTill = validTill;
        Payment = payment;
        IsCanceled = isCanceled;
    }
}
