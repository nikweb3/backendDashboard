using ViadexDashboard.Data;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Services
{
    public class ComplianceService : IComplianceService
    {
        private readonly AppDbContext _context;

        public ComplianceService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Compliance> GetAllDeviceCompliance() => _context.ComplianceData.ToList();

        public Compliance? GetDeviceComplianceById(int id) => _context.ComplianceData.Find(id);

        public void AddDeviceCompliance(Compliance compliance)
        {
            _context.ComplianceData.Add(compliance);
            _context.SaveChanges();
        }

        public void UpdateDeviceCompliance(Compliance compliance)
        {
            _context.ComplianceData.Update(compliance);
            _context.SaveChanges();
        }

        public void DeleteDeviceCompliance(int id)
        {
            var compliance = _context.ComplianceData.Find(id);
            if (compliance != null)
            {
                _context.ComplianceData.Remove(compliance);
                _context.SaveChanges();
            }
        }
    }
}
