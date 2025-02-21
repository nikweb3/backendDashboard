namespace ViadexDashboard.Models
{
    public class Telemetry
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public double CPUUsage { get; set; }
        public double MemoryUsage { get; set; }
        public double DiskUsage { get; set; }
        public DateTime RecordedAt { get; set; } 
    }
}
