using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_deviceService.GetAllDevices());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var device = _deviceService.GetDeviceById(id);
            return device != null ? Ok(device) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Device device)
        {
            _deviceService.AddDevice(device);
            return CreatedAtAction(nameof(GetById), new { id = device.Id }, device);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Device device)
        {
            if (id != device.Id) return BadRequest();
            _deviceService.UpdateDevice(device);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _deviceService.DeleteDevice(id);
            return NoContent();
        }
    }
}
