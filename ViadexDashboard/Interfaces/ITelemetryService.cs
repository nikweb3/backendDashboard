using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface ITelemetryService
    {
        IEnumerable<Telemetry> GetAllTelemetry();
        Telemetry? GetTelemetryById(int id);
        void AddDeviceTelemetry(Telemetry device);
        void UpdateDeviceTelemetry(Telemetry device);
        void DeleteDeviceTelemetry(int id);
    }
}
