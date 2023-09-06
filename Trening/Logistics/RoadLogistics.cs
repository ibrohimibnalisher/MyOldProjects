namespace Trening
{
    public class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new TruckTransport();
        }
    }
}