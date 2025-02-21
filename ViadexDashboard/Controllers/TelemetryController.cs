using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelemetryController : ControllerBase
    {
        private readonly ITelemetryService _telemetryService;

        public TelemetryController(ITelemetryService telemetryService)
        {
            _telemetryService = telemetryService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_telemetryService.GetAllTelemetry());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var deviceTelemetry = _telemetryService.GetTelemetryById(id);
            return deviceTelemetry != null ? Ok(deviceTelemetry) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Telemetry telemetry)
        {
            _telemetryService.AddDeviceTelemetry(telemetry);
            return CreatedAtAction(nameof(GetById), new { id = telemetry.Id }, telemetry);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Telemetry telemetry)
        {
            if (id != telemetry.Id) return BadRequest();
            _telemetryService.UpdateDeviceTelemetry(telemetry);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _telemetryService.DeleteDeviceTelemetry(id);
            return NoContent();
        }
    }
}
