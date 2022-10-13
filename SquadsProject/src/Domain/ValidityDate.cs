namespace Domain;

public class ValidityDate
{
    public DateTime ValidFrom { get; }
    public DateTime ValidTill { get; }

    public ValidityDate(DateTime validFrom, DateTime validTill)
    {
        ValidFrom = validFrom;
        ValidTill = validTill;
    }
}
