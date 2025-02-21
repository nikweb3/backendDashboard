using ViadexDashboard.Models;

namespace ViadexDashboard.Interfaces
{
    public interface IDEXScoreService
    {
        IEnumerable<DEXScore> GetAllDevicesDexScoreList();
        DEXScore? GetDeviceDexScoreById(int id);
        void AddDeviceDexScore(DEXScore device);
        void UpdateDeviceDexScore(DEXScore device);
        void DeleteDeviceDexScore(int id);
    }
}
