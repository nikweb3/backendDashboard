using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SustainabilityController : ControllerBase
    {
        private readonly ISustainabilityService _sustainabilityService;

        public SustainabilityController(ISustainabilityService sustainabilityService)
        {
            _sustainabilityService = sustainabilityService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_sustainabilityService.GetAllDeviceSustainabilityList());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var deviceSustainability = _sustainabilityService.GetDeviceSustainabilityById(id);
            return deviceSustainability != null ? Ok(deviceSustainability) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Sustainability sustainability)
        {
            _sustainabilityService.AddDeviceSustainability(sustainability);
            return CreatedAtAction(nameof(GetById), new { id = sustainability.Id }, sustainability);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Sustainability sustainability)
        {
            if (id != sustainability.Id) return BadRequest();
            _sustainabilityService.UpdateDeviceSustainability(sustainability);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _sustainabilityService.DeleteDeviceSustainability(id);
            return NoContent();
        }
    }
}
