namespace Domain;

public class MultipleUseCard
{
    private List<Reservation> _uses = new();
    public int AmountOfUses { get; private set; }
    public ValidityDate? ValidityDate { get; private set; }
    public Payment? Payment { get; private set; }

    /// <summary>
    /// Returns the amount of free uses available on the multiple use card
    /// </summary>
    public int AmountOfAvailableUses => AmountOfUses - _uses.Count;
    /// <summary>
    /// Returns whether the multiple use card has already been paid for
    /// </summary>
    public bool IsPaid => Payment != null;
    /// <summary>
    /// Returns a readonly list of uses
    /// </summary>
    public IReadOnlyList<Reservation> Uses => _uses.AsReadOnly();

    public MultipleUseCard(int amountOfUses)
    {
        AmountOfUses = amountOfUses;
    }

    /// <summary>
    /// Adds a payment to the multiple use card
    /// </summary>
    /// <exception cref="Exception"></exception>
    public Result AddPayment()
    {
        if (IsPaid)
        {
            Result.Fail("There already exists a payment");
        }

        Payment = new Payment();

        return Result.Ok();
    }

    /// <summary>
    /// Adds a new use to the uses list
    /// </summary>
    /// <exception cref="Exception"></exception>
    public Result AddUse(Session session)
    {
        if (IsValid().IsFailure)
        {
            return IsValid();
        }

        if (_uses.Count == 0)
        {
            ValidityDate = new ValidityDate(session.StartDate, session.EndDate.AddYears(1));
        }

        _uses.Add(new Reservation(session));

        return Result.Ok();
    }
    /*TO BE IMPLEMENTED*/
    public void RemoveUse(Reservation rese)
    {
        //Reservation useToBeRemoved = _uses.Remove(rese.);
    }
    /// <summary>
    /// Checks wether the multiple use card is still valid
    /// </summary>
    /// <returns>true or false</returns>
    private Result IsValid()
    {
        if (ValidityDate != null && ValidityDate.ValidTill < DateTime.UtcNow)
        {
            return Result.Fail("Multiple use card has expired");
        }

        if (_uses.Count >= AmountOfUses)
        {
            return Result.Fail("Multiple use card has no uses left");
        }

        return Result.Ok();
    }
}