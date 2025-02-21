using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface IDeviceService
    {
        IEnumerable<object> GetAllDevices();
        Device? GetDeviceById(int id);
        void AddDevice(Device device);
        void UpdateDevice(Device device);
        void DeleteDevice(int id);
    }
}
