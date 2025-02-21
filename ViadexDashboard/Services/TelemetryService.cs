using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Services
{
    public class TelemetryService : ITelemetryService
    {
        private readonly AppDbContext _context;

        public TelemetryService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Telemetry> GetAllTelemetry() => _context.TelemetryData.ToList();

        public Telemetry? GetTelemetryById(int id) => _context.TelemetryData.Find(id);

        public void AddDeviceTelemetry(Telemetry telemetry)
        {
            _context.TelemetryData.Add(telemetry);
            _context.SaveChanges();
        }

        public void UpdateDeviceTelemetry(Telemetry telemetry)
        {
            _context.TelemetryData.Update(telemetry);
            _context.SaveChanges();
        }

        public void DeleteDeviceTelemetry(int id)
        {
            var telemetry = _context.TelemetryData.Find(id);
            if (telemetry != null)
            {
                _context.TelemetryData.Remove(telemetry);
                _context.SaveChanges();
            }
        }
    }
}
