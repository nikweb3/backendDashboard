using Microsoft.AspNetCore.Mvc;
using ViadexDashboard.Interfaces;

[Route("api/[controller]")]
[ApiController]
public class ComponentsController : ControllerBase
{
    private readonly IComponentService _componentService;

    public ComponentsController(IComponentService componentService)
    {
        _componentService = componentService;
    }
    // GET
    [HttpGet]
    public IActionResult Get()
    {
        var component = _componentService.GetAllComponents();
        return Ok(component); 
    }

    // POST: api/components
    [HttpPost]
    public IActionResult CreateComponent([FromBody] Component component)
    {
        if (component == null)
        {
            return BadRequest("Invalid component data.");
        }

        // Set timestamps for the component
        component.CreatedAt = DateTime.UtcNow;
        component.UpdatedAt = DateTime.UtcNow;

        // Add the component and save it
        _componentService.AddComponent(component);

        // Return the created component with a 201 status
        return CreatedAtAction(nameof(GetComponentById), new { id = component.Id }, component);
    }

    // GET: api/components/{id}
    [HttpGet("{id}")]
    public IActionResult GetComponentById(int id)
    {
        var component = _componentService.GetComponentById(id);
        if (component == null)
        {
            return NotFound(); // Returns a 404 if the component is not found
        }
        return Ok(component); // Returns the component in a 200 OK response
    }

    // PUT: api/components/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateComponent(int id, [FromBody] Component component)
    {
        if (component == null || component.Id != id)
        {
            return BadRequest("Component ID mismatch.");
        }

        var existingComponent = _componentService.GetComponentById(id);
        if (existingComponent == null)
        {
            return NotFound(); // Returns a 404 if the component to update is not found
        }

        _componentService.UpdateComponent(component);
        return NoContent(); // Returns a 204 No Content response after updating
    }

    // DELETE: api/components/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteComponent(int id)
    {
        var component = _componentService.GetComponentById(id);
        if (component == null)
        {
            return NotFound(); // Returns a 404 if the component is not found
        }

        _componentService.DeleteComponent(id);
        return NoContent(); // Returns a 204 No Content response after deletion
    }
}
