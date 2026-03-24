namespace OOPWeek8_Chybuk;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; }

    public Parcel(string TrackingNumber, double Weight, string dimensions) : base(TrackingNumber, Weight)
    {
        Dimensions = dimensions;
    }
    public override double CalculateCost()
    {
        return (50 + (Weight * 25));
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"tracknumber: {TrackingNumber}");
        Console.WriteLine($"weight {Weight} kg");
        Console.WriteLine($"dimensions: {Dimensions}");
    }
}