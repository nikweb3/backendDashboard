using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface ISustainabilityService
    {
        IEnumerable<Sustainability> GetAllDeviceSustainabilityList();
        Sustainability? GetDeviceSustainabilityById(int id);
        void AddDeviceSustainability(Sustainability device);
        void UpdateDeviceSustainability(Sustainability device);
        void DeleteDeviceSustainability(int id);
    }
}
