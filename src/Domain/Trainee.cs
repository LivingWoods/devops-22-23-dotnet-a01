namespace Squads.Domain;

public class Trainee 
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string PhoneNumber { get; private set; }
    public string PhysicalIssues { get; private set; }
    public string DrugsUsed { get; private set; }
    public double Length { get; private set; }
    public bool NewsLetterOptedIn { get; private set; }
    public bool WhatsappOptedIn { get; private set; }
    public bool HasSignedHouseRules { get; private set; }
    public bool HasUsedFreeLesson { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }
    public List<Measurement> Measurements { get; private set; } = new();
    public List<MultipleUseCard> MultipleUseCards { get; private set; } = new();
    public List<Subscription> Subscriptions { get; private set; } = new();
    public List<PersonalRecord> PersonalRecords { get; private set; } = new();

    public Trainee(string firstName, string lastName, DateTime birthDate, string phoneNumber, string physicalIssues, string drugsUsed, double length, bool newsLetterOptedIn, bool whatsappOptedIn, bool hasSignedHouseRules, bool hasUsedFreeLesson, Email email, Address address, List<Measurement> measurements, List<MultipleUseCard> multipleUseCards, List<Subscription> subscriptions, List<PersonalRecord> personalRecords)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        PhoneNumber = phoneNumber;
        PhysicalIssues = physicalIssues;
        DrugsUsed = drugsUsed;
        Length = length;
        NewsLetterOptedIn = newsLetterOptedIn;
        WhatsappOptedIn = whatsappOptedIn;
        HasSignedHouseRules = hasSignedHouseRules;
        HasUsedFreeLesson = hasUsedFreeLesson;
        Email = email;
        Address = address;
        Measurements = measurements;
        MultipleUseCards = multipleUseCards;
        Subscriptions = subscriptions;
        PersonalRecords = personalRecords;
    }
}