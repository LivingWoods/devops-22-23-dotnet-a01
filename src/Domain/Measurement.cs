namespace Domain;

public class Measurement
{
    public double Weight { get; private set; }
    public double FatPercentage { get; private set; }
    public double MusclePercentage { get; private set; }
    public double WaistCircumference { get; private set; }
    public DateTime MeasuredOn { get; private set; }

    public Measurement(double weight, double fatPercentage, double musclePercentage, double waistCircumference, DateTime measuredOn)
    {
        

        Weight = Guard.Against.NegativeOrZero(weight, nameof(weight));
        FatPercentage = Guard.Against.NegativeOrZero(fatPercentage, nameof(fatPercentage));
        MusclePercentage = Guard.Against.NegativeOrZero(musclePercentage, nameof(musclePercentage));
        WaistCircumference = Guard.Against.NegativeOrZero(waistCircumference, nameof(waistCircumference));
        MeasuredOn = Guard.Against.OutOfRange(measuredOn, nameof(measuredOn), DateTime.MinValue, DateTime.UtcNow);
    }
}
