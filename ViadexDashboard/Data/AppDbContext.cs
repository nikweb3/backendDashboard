using Microsoft.EntityFrameworkCore;
using ViadexDashboard.Models;

namespace ViadexDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Telemetry> TelemetryData { get; set; }
        public DbSet<Compliance> ComplianceData { get; set; }
        public DbSet<Sustainability> SustainabilityData { get; set; }
        public DbSet<DEXScore> DEXScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().HasData(
                new Device { Id = 1, Name = "Laptop1", OS = "Windows 10", SerialNumber = "SN001" },
                new Device { Id = 2, Name = "Laptop2", OS = "Windows 11", SerialNumber = "SN002" },
                new Device { Id = 3, Name = "Laptop3", OS = "Windows 10", SerialNumber = "SN003" },
                new Device { Id = 4, Name = "Laptop4", OS = "Windows 11", SerialNumber = "SN004" },
                new Device { Id = 5, Name = "Laptop5", OS = "Windows 10", SerialNumber = "SN005" },
                new Device { Id = 6, Name = "Laptop6", OS = "Windows 11", SerialNumber = "SN006" },
                new Device { Id = 7, Name = "Laptop7", OS = "Windows 10", SerialNumber = "SN007" },
                new Device { Id = 8, Name = "Laptop8", OS = "Windows 11", SerialNumber = "SN008" },
                new Device { Id = 9, Name = "Laptop9", OS = "Windows 10", SerialNumber = "SN009" },
                new Device { Id = 10, Name = "Laptop10", OS = "Windows 11", SerialNumber = "SN010" },
                new Device { Id = 11, Name = "Laptop11", OS = "Windows 10", SerialNumber = "SN011" },
                new Device { Id = 12, Name = "Laptop12", OS = "Windows 11", SerialNumber = "SN012" },
                new Device { Id = 13, Name = "Laptop13", OS = "Windows 10", SerialNumber = "SN013" },
                new Device { Id = 14, Name = "Laptop14", OS = "Windows 11", SerialNumber = "SN014" },
                new Device { Id = 15, Name = "Laptop15", OS = "Windows 10", SerialNumber = "SN015" },
                new Device { Id = 16, Name = "Laptop16", OS = "Windows 11", SerialNumber = "SN016" },
                new Device { Id = 17, Name = "Laptop17", OS = "Windows 10", SerialNumber = "SN017" },
                new Device { Id = 18, Name = "Laptop18", OS = "Windows 11", SerialNumber = "SN018" },
                new Device { Id = 19, Name = "Laptop19", OS = "Windows 10", SerialNumber = "SN019" },
                new Device { Id = 20, Name = "Laptop20", OS = "Windows 11", SerialNumber = "SN020" },
                new Device { Id = 21, Name = "Laptop21", OS = "Windows 10", SerialNumber = "SN021" },
                new Device { Id = 22, Name = "Laptop22", OS = "Windows 11", SerialNumber = "SN022" },
                new Device { Id = 23, Name = "Laptop23", OS = "Windows 10", SerialNumber = "SN023" },
                new Device { Id = 24, Name = "Laptop24", OS = "Windows 11", SerialNumber = "SN024" },
                new Device { Id = 25, Name = "Laptop25", OS = "Windows 10", SerialNumber = "SN025" }
            );

            modelBuilder.Entity<Telemetry>().HasData(
                new Telemetry { Id = 1, DeviceId = 1, CPUUsage = 25.5, MemoryUsage = 35.2, DiskUsage = 45.1, RecordedAt = new DateTime(2024, 1, 1, 10, 30, 0) },
                new Telemetry { Id = 2, DeviceId = 2, CPUUsage = 22.3, MemoryUsage = 32.8, DiskUsage = 48.5, RecordedAt = new DateTime(2024, 1, 2, 11, 15, 0) },
                new Telemetry { Id = 3, DeviceId = 3, CPUUsage = 30.1, MemoryUsage = 40.7, DiskUsage = 50.3, RecordedAt = new DateTime(2024, 1, 3, 9, 45, 0) },
                new Telemetry { Id = 4, DeviceId = 4, CPUUsage = 28.4, MemoryUsage = 38.9, DiskUsage = 47.6, RecordedAt = new DateTime(2024, 1, 4, 14, 20, 0) },
                new Telemetry { Id = 5, DeviceId = 5, CPUUsage = 27.8, MemoryUsage = 37.2, DiskUsage = 46.3, RecordedAt = new DateTime(2024, 1, 5, 16, 10, 0) },
                new Telemetry { Id = 6, DeviceId = 6, CPUUsage = 26.9, MemoryUsage = 36.1, DiskUsage = 45.0, RecordedAt = new DateTime(2024, 1, 6, 8, 55, 0) },
                new Telemetry { Id = 7, DeviceId = 7, CPUUsage = 29.5, MemoryUsage = 39.5, DiskUsage = 49.1, RecordedAt = new DateTime(2024, 1, 7, 12, 35, 0) },
                new Telemetry { Id = 8, DeviceId = 8, CPUUsage = 31.2, MemoryUsage = 41.8, DiskUsage = 50.7, RecordedAt = new DateTime(2024, 1, 8, 13, 25, 0) },
                new Telemetry { Id = 9, DeviceId = 9, CPUUsage = 24.1, MemoryUsage = 34.2, DiskUsage = 44.5, RecordedAt = new DateTime(2024, 1, 9, 15, 40, 0) },
                new Telemetry { Id = 10, DeviceId = 10, CPUUsage = 32.8, MemoryUsage = 43.7, DiskUsage = 51.9, RecordedAt = new DateTime(2024, 1, 10, 17, 50, 0) },
                new Telemetry { Id = 11, DeviceId = 11, CPUUsage = 30.5, MemoryUsage = 40.2, DiskUsage = 48.1, RecordedAt = new DateTime(2024, 1, 11, 10, 30, 0) },
                new Telemetry { Id = 12, DeviceId = 12, CPUUsage = 27.2, MemoryUsage = 36.9, DiskUsage = 45.6, RecordedAt = new DateTime(2024, 1, 12, 14, 10, 0) },
                new Telemetry { Id = 13, DeviceId = 13, CPUUsage = 26.4, MemoryUsage = 35.7, DiskUsage = 44.3, RecordedAt = new DateTime(2024, 1, 13, 9, 20, 0) },
                new Telemetry { Id = 14, DeviceId = 14, CPUUsage = 28.9, MemoryUsage = 39.2, DiskUsage = 48.4, RecordedAt = new DateTime(2024, 1, 14, 13, 30, 0) },
                new Telemetry { Id = 15, DeviceId = 15, CPUUsage = 31.5, MemoryUsage = 42.7, DiskUsage = 50.1, RecordedAt = new DateTime(2024, 1, 15, 16, 45, 0) },
                new Telemetry { Id = 16, DeviceId = 16, CPUUsage = 23.8, MemoryUsage = 33.5, DiskUsage = 43.2, RecordedAt = new DateTime(2024, 1, 16, 10, 20, 0) },
                new Telemetry { Id = 17, DeviceId = 17, CPUUsage = 25.9, MemoryUsage = 37.4, DiskUsage = 47.8, RecordedAt = new DateTime(2024, 1, 17, 14, 15, 0) },
                new Telemetry { Id = 18, DeviceId = 18, CPUUsage = 29.8, MemoryUsage = 41.5, DiskUsage = 50.9, RecordedAt = new DateTime(2024, 1, 18, 15, 50, 0) },
                new Telemetry { Id = 19, DeviceId = 19, CPUUsage = 22.5, MemoryUsage = 32.1, DiskUsage = 42.7, RecordedAt = new DateTime(2024, 1, 19, 11, 10, 0) },
                new Telemetry { Id = 20, DeviceId = 20, CPUUsage = 24.9, MemoryUsage = 35.2, DiskUsage = 48.4, RecordedAt = new DateTime(2024, 1, 20, 13, 30, 0) },
                new Telemetry { Id = 21, DeviceId = 21, CPUUsage = 38.5, MemoryUsage = 46.7, DiskUsage = 55.1, RecordedAt = new DateTime(2024, 1, 21, 9, 45, 0) },
                new Telemetry { Id = 22, DeviceId = 22, CPUUsage = 27.8, MemoryUsage = 38.5, DiskUsage = 33.2, RecordedAt = new DateTime(2024, 1, 22, 12, 55, 0) },
                new Telemetry { Id = 23, DeviceId = 23, CPUUsage = 39.9, MemoryUsage = 17.4, DiskUsage = 27.8, RecordedAt = new DateTime(2024, 1, 23, 15, 10, 0) },
                new Telemetry { Id = 24, DeviceId = 24, CPUUsage = 19.8, MemoryUsage = 61.5, DiskUsage = 30.9, RecordedAt = new DateTime(2024, 1, 24, 11, 40, 0) },
                new Telemetry { Id = 25, DeviceId = 25, CPUUsage = 25.8, MemoryUsage = 22.1, DiskUsage = 22.7, RecordedAt = new DateTime(2024, 1, 25, 14, 20, 0) }
            );

            modelBuilder.Entity<Compliance>().HasData(
                new Compliance { Id = 1, DeviceId = 1, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 2, DeviceId = 2, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 3, DeviceId = 3, EncryptionEnabled = false, PolicyCompliant = false },
                new Compliance { Id = 4, DeviceId = 4, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 5, DeviceId = 5, EncryptionEnabled = false, PolicyCompliant = true },
                new Compliance { Id = 6, DeviceId = 6, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 7, DeviceId = 7, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 8, DeviceId = 8, EncryptionEnabled = false, PolicyCompliant = false },
                new Compliance { Id = 9, DeviceId = 9, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 10, DeviceId = 10, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 11, DeviceId = 11, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 12, DeviceId = 12, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 13, DeviceId = 13, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 14, DeviceId = 14, EncryptionEnabled = false, PolicyCompliant = false },
                new Compliance { Id = 15, DeviceId = 15, EncryptionEnabled = false, PolicyCompliant = true },
                new Compliance { Id = 16, DeviceId = 16, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 17, DeviceId = 17, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 18, DeviceId = 18, EncryptionEnabled = false, PolicyCompliant = false },
                new Compliance { Id = 19, DeviceId = 19, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 20, DeviceId = 20, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 21, DeviceId = 21, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 22, DeviceId = 22, EncryptionEnabled = true, PolicyCompliant = false },
                new Compliance { Id = 23, DeviceId = 23, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 24, DeviceId = 24, EncryptionEnabled = true, PolicyCompliant = true },
                new Compliance { Id = 25, DeviceId = 25, EncryptionEnabled = true, PolicyCompliant = true }
            );

            modelBuilder.Entity<Sustainability>().HasData(
                new Sustainability { Id = 1, DeviceId = 1, PowerConsumption = 50.5, CarbonFootprint = 10.2 },
                new Sustainability { Id = 2, DeviceId = 2, PowerConsumption = 45.3, CarbonFootprint = 9.8 },
                new Sustainability { Id = 3, DeviceId = 3, PowerConsumption = 52.1, CarbonFootprint = 11.0 },
                new Sustainability { Id = 4, DeviceId = 4, PowerConsumption = 48.7, CarbonFootprint = 10.5 },
                new Sustainability { Id = 5, DeviceId = 5, PowerConsumption = 47.2, CarbonFootprint = 9.9 },
                new Sustainability { Id = 6, DeviceId = 6, PowerConsumption = 49.8, CarbonFootprint = 10.6 },
                new Sustainability { Id = 7, DeviceId = 7, PowerConsumption = 53.5, CarbonFootprint = 11.4 },
                new Sustainability { Id = 8, DeviceId = 8, PowerConsumption = 46.9, CarbonFootprint = 9.7 },
                new Sustainability { Id = 9, DeviceId = 9, PowerConsumption = 51.0, CarbonFootprint = 10.9 },
                new Sustainability { Id = 10, DeviceId = 10, PowerConsumption = 50.2, CarbonFootprint = 10.3 },
                new Sustainability { Id = 11, DeviceId = 11, PowerConsumption = 48.0, CarbonFootprint = 10.0 },
                new Sustainability { Id = 12, DeviceId = 12, PowerConsumption = 45.7, CarbonFootprint = 9.6 },
                new Sustainability { Id = 13, DeviceId = 13, PowerConsumption = 54.2, CarbonFootprint = 11.8 },
                new Sustainability { Id = 14, DeviceId = 14, PowerConsumption = 47.5, CarbonFootprint = 9.8 },
                new Sustainability { Id = 15, DeviceId = 15, PowerConsumption = 50.9, CarbonFootprint = 10.7 },
                new Sustainability { Id = 16, DeviceId = 16, PowerConsumption = 49.4, CarbonFootprint = 10.4 },
                new Sustainability { Id = 17, DeviceId = 17, PowerConsumption = 52.8, CarbonFootprint = 11.2 },
                new Sustainability { Id = 18, DeviceId = 18, PowerConsumption = 48.3, CarbonFootprint = 10.1 },
                new Sustainability { Id = 19, DeviceId = 19, PowerConsumption = 47.0, CarbonFootprint = 9.7 },
                new Sustainability { Id = 20, DeviceId = 20, PowerConsumption = 50.7, CarbonFootprint = 10.6 },
                new Sustainability { Id = 21, DeviceId = 21, PowerConsumption = 46.5, CarbonFootprint = 9.5 },
                new Sustainability { Id = 22, DeviceId = 22, PowerConsumption = 51.3, CarbonFootprint = 10.8 },
                new Sustainability { Id = 23, DeviceId = 23, PowerConsumption = 49.9, CarbonFootprint = 10.5 },
                new Sustainability { Id = 24, DeviceId = 24, PowerConsumption = 53.0, CarbonFootprint = 11.1 },
                new Sustainability { Id = 25, DeviceId = 25, PowerConsumption = 48.6, CarbonFootprint = 10.2 }
            );

            modelBuilder.Entity<DEXScore>().HasData(
                new DEXScore { Id = 1, DeviceId = 1, PerformanceScore = 85.0, UserFeedbackScore = 4.2 },
                new DEXScore { Id = 2, DeviceId = 2, PerformanceScore = 90.3, UserFeedbackScore = 4.5 },
                new DEXScore { Id = 3, DeviceId = 3, PerformanceScore = 78.5, UserFeedbackScore = 3.9 },
                new DEXScore { Id = 4, DeviceId = 4, PerformanceScore = 88.1, UserFeedbackScore = 4.3 },
                new DEXScore { Id = 5, DeviceId = 5, PerformanceScore = 92.4, UserFeedbackScore = 4.7 },
                new DEXScore { Id = 6, DeviceId = 6, PerformanceScore = 80.2, UserFeedbackScore = 4.0 },
                new DEXScore { Id = 7, DeviceId = 7, PerformanceScore = 83.6, UserFeedbackScore = 4.1 },
                new DEXScore { Id = 8, DeviceId = 8, PerformanceScore = 87.9, UserFeedbackScore = 4.4 },
                new DEXScore { Id = 9, DeviceId = 9, PerformanceScore = 91.5, UserFeedbackScore = 4.6 },
                new DEXScore { Id = 10, DeviceId = 10, PerformanceScore = 76.8, UserFeedbackScore = 3.8 },
                new DEXScore { Id = 11, DeviceId = 11, PerformanceScore = 85.7, UserFeedbackScore = 4.2 },
                new DEXScore { Id = 12, DeviceId = 12, PerformanceScore = 89.2, UserFeedbackScore = 4.3 },
                new DEXScore { Id = 13, DeviceId = 13, PerformanceScore = 93.1, UserFeedbackScore = 4.8 },
                new DEXScore { Id = 14, DeviceId = 14, PerformanceScore = 79.4, UserFeedbackScore = 3.9 },
                new DEXScore { Id = 15, DeviceId = 15, PerformanceScore = 86.3, UserFeedbackScore = 4.2 },
                new DEXScore { Id = 16, DeviceId = 16, PerformanceScore = 90.0, UserFeedbackScore = 4.5 },
                new DEXScore { Id = 17, DeviceId = 17, PerformanceScore = 81.7, UserFeedbackScore = 4.0 },
                new DEXScore { Id = 18, DeviceId = 18, PerformanceScore = 84.5, UserFeedbackScore = 4.1 },
                new DEXScore { Id = 19, DeviceId = 19, PerformanceScore = 88.8, UserFeedbackScore = 4.4 },
                new DEXScore { Id = 20, DeviceId = 20, PerformanceScore = 75.9, UserFeedbackScore = 3.7 },
                new DEXScore { Id = 21, DeviceId = 21, PerformanceScore = 82.6, UserFeedbackScore = 4.0 },
                new DEXScore { Id = 22, DeviceId = 22, PerformanceScore = 87.2, UserFeedbackScore = 4.3 },
                new DEXScore { Id = 23, DeviceId = 23, PerformanceScore = 92.0, UserFeedbackScore = 4.6 },
                new DEXScore { Id = 24, DeviceId = 24, PerformanceScore = 77.5, UserFeedbackScore = 3.8 },
                new DEXScore { Id = 25, DeviceId = 25, PerformanceScore = 89.7, UserFeedbackScore = 4.4 }
            );
        }
    }
}
