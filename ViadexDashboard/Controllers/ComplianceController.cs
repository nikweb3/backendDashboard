using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplianceController : ControllerBase
    {
        private readonly IComplianceService _complianceService;

        public ComplianceController(IComplianceService complianceService)
        {
            _complianceService = complianceService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_complianceService.GetAllDeviceCompliance());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var compliance = _complianceService.GetDeviceComplianceById(id);
            return compliance != null ? Ok(compliance) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Compliance compliance)
        {
            _complianceService.AddDeviceCompliance(compliance);
            return CreatedAtAction(nameof(GetById), new { id = compliance.Id }, compliance);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Compliance compliance)
        {
            if (id != compliance.Id) return BadRequest();
            _complianceService.UpdateDeviceCompliance(compliance);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _complianceService.DeleteDeviceCompliance(id);
            return NoContent();
        }
    }
}
