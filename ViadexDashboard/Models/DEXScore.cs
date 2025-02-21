namespace ViadexDashboard.Models
{
    public class DEXScore
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public double PerformanceScore { get; set; }
        public double UserFeedbackScore { get; set; }
    }
}
