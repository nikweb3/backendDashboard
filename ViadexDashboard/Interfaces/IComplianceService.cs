using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface IComplianceService
    {
        IEnumerable<Compliance> GetAllDeviceCompliance();
        Compliance? GetDeviceComplianceById(int id);
        void AddDeviceCompliance(Compliance device);
        void UpdateDeviceCompliance(Compliance device);
        void DeleteDeviceCompliance(int id);
    }
}
