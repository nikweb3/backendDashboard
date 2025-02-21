using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Services
{
    public class DexScoreService : IDEXScoreService
    {
        private readonly AppDbContext _context;

        public DexScoreService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DEXScore> GetAllDevicesDexScoreList() => _context.DEXScores.ToList();

        public DEXScore? GetDeviceDexScoreById(int id) => _context.DEXScores.Find(id);

        public void AddDeviceDexScore(DEXScore dexscore)
        {
            _context.DEXScores.Add(dexscore);
            _context.SaveChanges();
        }

        public void UpdateDeviceDexScore(DEXScore dexscore)
        {
            _context.DEXScores.Update(dexscore);
            _context.SaveChanges();
        }

        public void DeleteDeviceDexScore(int id)
        {
            var dexscore = _context.DEXScores.Find(id);
            if (dexscore != null)
            {
                _context.DEXScores.Remove(dexscore);
                _context.SaveChanges();
            }
        }
    }
}
