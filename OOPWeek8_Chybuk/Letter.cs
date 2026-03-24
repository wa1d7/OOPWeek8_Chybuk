namespace OOPWeek8_Chybuk;

public class Letter : DeliveryItem
{
    public Letter(string TrackingNumber, double Weight) : base(TrackingNumber, Weight)
    {
        
    }

    public override double CalculateCost()
    {
        return (15 + (Weight * 10));
    }
}