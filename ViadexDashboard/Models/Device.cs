namespace ViadexDashboard.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string OS { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public ICollection<Telemetry> TelemetryData { get; set; } = new List<Telemetry>();
        public Compliance? Compliance { get; set; }
        public Sustainability? Sustainability { get; set; }
        public DEXScore? DexScore { get; set; }
    }
}
