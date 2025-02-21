namespace ViadexDashboard.Models
{
    public class Sustainability
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public double PowerConsumption { get; set; }
        public double CarbonFootprint { get; set; }
    }
}
