using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Services
{
    public class SustainabilityService : ISustainabilityService
    {
        private readonly AppDbContext _context;

        public SustainabilityService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sustainability> GetAllDeviceSustainabilityList() => _context.SustainabilityData.ToList();

        public Sustainability? GetDeviceSustainabilityById(int id) => _context.SustainabilityData.Find(id);

        public void AddDeviceSustainability(Sustainability sustainability)
        {
            _context.SustainabilityData.Add(sustainability);
            _context.SaveChanges();
        }

        public void UpdateDeviceSustainability(Sustainability sustainability)
        {
            _context.SustainabilityData.Update(sustainability);
            _context.SaveChanges();
        }

        public void DeleteDeviceSustainability(int id)
        {
            var sustainability = _context.SustainabilityData.Find(id);
            if (sustainability != null)
            {
                _context.SustainabilityData.Remove(sustainability);
                _context.SaveChanges();
            }
        }
    }
}
