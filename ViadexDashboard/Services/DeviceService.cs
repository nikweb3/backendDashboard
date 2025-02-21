using Microsoft.EntityFrameworkCore;
using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly AppDbContext _context;

        public DeviceService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<object> GetAllDevices()
        {
            return _context.Devices
                .AsNoTracking()
                .Select(d => new
                {
                    d.Id,
                    d.Name,
                    d.OS,
                    d.SerialNumber,
                    TelemetryData = d.TelemetryData.Select(t => new
                    {
                        t.Id,
                        t.CPUUsage,
                        t.MemoryUsage
                    }),
                    Compliance = d.Compliance != null ? new
                    {
                        d.Compliance.EncryptionEnabled,
                        d.Compliance.PolicyCompliant
                    } : null,
                    Sustainability = d.Sustainability != null ? new
                    {
                        d.Sustainability.PowerConsumption,
                        d.Sustainability.CarbonFootprint
                    } : null,
                    DexScore = d.DexScore != null ? new
                    {
                        d.DexScore.PerformanceScore,
                        d.DexScore.UserFeedbackScore
                    } : null
                })
                .ToList();
        }


        public Device? GetDeviceById(int id) => _context.Devices.Find(id);

        public void AddDevice(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
        }

        public void UpdateDevice(Device device)
        {
            _context.Devices.Update(device);
            _context.SaveChanges();
        }

        public void DeleteDevice(int id)
        {
            var device = _context.Devices.Find(id);
            if (device != null)
            {
                _context.Devices.Remove(device);
                _context.SaveChanges();
            }
        }
    }
}
