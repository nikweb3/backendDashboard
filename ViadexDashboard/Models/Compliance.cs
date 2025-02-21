namespace ViadexDashboard.Models
{
    public class Compliance
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public bool EncryptionEnabled { get; set; }
        public bool PolicyCompliant { get; set; }
    }
}
