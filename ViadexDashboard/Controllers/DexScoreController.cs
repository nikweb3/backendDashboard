using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;
using ViadexDashboard.Models;

namespace ViadexDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DexScoreController : ControllerBase
    {
        private readonly IDEXScoreService _dexScoreService;

        public DexScoreController(IDEXScoreService dexScoreService)
        {
            _dexScoreService = dexScoreService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_dexScoreService.GetAllDevicesDexScoreList());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var dexScore = _dexScoreService.GetDeviceDexScoreById(id);
            return dexScore != null ? Ok(dexScore) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] DEXScore dexScore)
        {
            _dexScoreService.AddDeviceDexScore(dexScore);
            return CreatedAtAction(nameof(GetById), new { id = dexScore.Id }, dexScore);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] DEXScore dexScore)
        {
            if (id != dexScore.Id) return BadRequest();
            _dexScoreService.UpdateDeviceDexScore(dexScore);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _dexScoreService.DeleteDeviceDexScore(id);
            return NoContent();
        }
    }
}
